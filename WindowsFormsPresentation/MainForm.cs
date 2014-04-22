using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using MadWizard.WinUSBNet;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using ButtonState = Microsoft.Xna.Framework.Input.ButtonState;

namespace WindowsFormsPresentation
{
    public partial class MainForm : Form
    {
        private List<string> _Last10Messages;
        private GamePadState _PreviousGamepadState;
        private Vector2 _PreviousBotVector;
        private SerialPort _Port;
        private bool _Connected;
        public MainForm()
        {
            InitializeComponent();
            
            Controller1PortComboBox.Items.AddRange
            (
                SerialPort
                .GetPortNames()
                .Select(p => new ListViewItem(p))
                .ToArray()
            );
            using (var db = new BotInteractionContainer())
            {
                Controller1LayoutComboBox.Items.AddRange(db.ControllerLayouts.Select(cl=>cl.Name).ToArray());
            }
            _Connected = false;
            _Last10Messages = new List<string>() { "Hello World" };

            GamePadState playerOneGamePadState = GamePad.GetState(PlayerIndex.One);
            if (playerOneGamePadState.IsConnected)
            {
                _Last10Messages.Add("Game pad connected");
            }
            ButtonsPressedTextBox.Lines = _Last10Messages.ToArray();
            _PreviousGamepadState = GamePad.GetState(PlayerIndex.One);
            _PreviousBotVector = _PreviousGamepadState.ThumbSticks.Left;
            Application.Idle += ProcessGampadStateWhileIdle;
        }


        void ProcessGampadStateWhileIdle(object sender, EventArgs e)
        {
            NativeMethods.NativeMessage message;
            while (IsApplicationIdle())
            {
                ProcessGamepadState(sender, e);
                System.Threading.Thread.Sleep(18);
            }
        }

        byte[] _ConvertPercentToBytes(float percent)
        {
            byte byteOne = (byte)0x00;
            byte byteTwo = (byte)0x00;
            int zeroOneOffset = 72;
            int oneTwoOffset = 56;
            int ofOneHundred = (int)(percent * 100);
            if (ofOneHundred > 55)
            {
                byteOne = (byte)0x02;
                byteTwo = (byte)(ofOneHundred-oneTwoOffset);
            }
            else {
                if (ofOneHundred < -zeroOneOffset)
                {
                    byteOne = (byte)0x00;
                    byteTwo = (byte)(ofOneHundred + zeroOneOffset-128);
                }
                else
                {
                    byteOne = (byte)0x01;
                    byteTwo = (byte)(ofOneHundred + zeroOneOffset);
                }
            }
            return new byte[2]{byteOne, byteTwo};
        }
        byte[] _GetSerialCommand(Vector2 botVector)
        {
            byte startByte = (byte)0x02; 
            byte endByte = (byte)0x03;
            byte[] xBytes = _ConvertPercentToBytes(botVector.X);
            byte[] yBytes = _ConvertPercentToBytes(botVector.Y);
            byte[] serialBytes = new byte[6]{startByte, xBytes[0], xBytes[1], yBytes[0], yBytes[1],endByte};
            return serialBytes;
        }

        string _getSerialCommandToString(byte[] serialBytes){
            return String.Join(" ", serialBytes.Select(b => b.ToString("X2")));
        }

        void ProcessGamepadState(object sender, EventArgs e)
        {
            GamePadState currentState = GamePad.GetState(PlayerIndex.One, GamePadDeadZone.Circular);
            if (HasInputChanged(_PreviousGamepadState, currentState, true))
            {
                Vector2 botVector = currentState.ThumbSticks.Left;
                if (botVector != _PreviousBotVector)
                {
                    byte[] message = _GetSerialCommand(botVector);
                    string fakeSerialMessage = _getSerialCommandToString(message); 
                    SendMessageToTextBox(fakeSerialMessage);
                    sendRealSerialMessage(message);
                }

            }
            _PreviousGamepadState = currentState;
        }

        bool IsApplicationIdle()
        {
            Message result;
            return !NativeMethods.PeekMessage(out result, IntPtr.Zero, 0, 0, 0);
        }

        void SendMessageToTextBox(string message)
        {
            _Last10Messages.Insert(0, message);
            if (_Last10Messages.Count > 9)
            {
                _Last10Messages.RemoveAt(9);
            }
            ButtonsPressedTextBox.Lines = _Last10Messages.ToArray();
        }

        void sendRealSerialMessage(byte[] message)
        {
            if ( _Port.IsOpen )
                _Port.Write(message,0,6);
        }

        private bool _ThumbstickHasChanged(Vector2 previousThumbstick, Vector2 currentThumbstick)
        {
            return previousThumbstick.Length() != currentThumbstick.Length() ;
        }
        public bool HasInputChanged(GamePadState previousGamePadState, GamePadState currentState, bool ignoreThumbsticks)
        { 
            if ((currentState.IsConnected) && (currentState.PacketNumber != previousGamePadState.PacketNumber))
            {
                return true;
            }
            return false;
        }

        private void ConnectButton_Click(object sender, EventArgs e)
        {
            if (!_Connected)
            {
                string portName = ((ListViewItem)Controller1PortComboBox.SelectedItem).Text;
                _Port = new SerialPort(portName, 9600);
                try
                {
                    _Port.Open();
                    SendMessageToTextBox("Connection Established");
                    ConnectButton.Text = "Disconnect";
                    _Connected = true;
                }
                catch (System.IO.IOException ioException)
                {
                    SendMessageToTextBox(ioException.Message);
                }
                catch (UnauthorizedAccessException uaException)
                {
                    SendMessageToTextBox(uaException.Message);
                }
            }
            else
            {
                _Port.Close();
                ConnectButton.Text = "Connect";
                SendMessageToTextBox("Connection Closed");
                _Connected = false;
            }
        }
    }

}
