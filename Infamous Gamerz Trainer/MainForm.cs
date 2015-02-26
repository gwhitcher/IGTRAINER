using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Globalization;
using System.Text.RegularExpressions;

namespace Infamous_Gamerz_Trainer
{

    public partial class hMainWindow : Form
	{
        public static class Defines
        {
            public const string process_name = "pso";
        }

        Memory oMemory = new Memory();
		const int iNORMAL = 0;
		const int iNOPPED = 1;
		const int iOTHER = 2;

		public hMainWindow()
		{
			InitializeComponent();
		}

		private void hSearchForProcess_Tick(object sender, EventArgs e) //Search for Process Timer
		{
			Process[] aProcesses = Process.GetProcessesByName(Defines.process_name); //Find .exe by process name
			if (aProcesses.Length != 0) //If Process Exists
			{
				if (oMemory.ReadProcess == null) //Process Not Attached
				{
					oMemory.ReadProcess = aProcesses[0]; //Set Process to Read
					oMemory.Open(); //Open Process
				}

				hProcess_Status.Text = "Infamous Gamerz [" + oMemory.PID().ToString() + "] (0x" + oMemory.BaseAddressH() + ")"; //Set Process Status
			}
			else //If Process Doesn't Exist
			{
				hProcess_Status.Text = "Searching for Process..."; //Set Process Status
				
				if (oMemory.ReadProcess != null) //Process Attached
				{
					oMemory.CloseHandle(); //Close Handle to Process
					oMemory.ReadProcess = null;
				}

			}
		}

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo("http://infamousgamerz.net");
            Process.Start(sInfo);
        }

        private void memoryedit1_Click(object sender, EventArgs e)
        {
            if (memoryedit1.Text == "Hack Off")
            {
                memoryedit1.Text = "Hack On";
                //ENTER CODE TO TURN OFF YOUR HACK HERE IF YOU SO CHOOSE!
            }
            else
            {
                memoryedit1.Text = "Hack Off";
                Process[] aProcesses = Process.GetProcessesByName(Defines.process_name);
                if (aProcesses.Length != 0)
                {
                    oMemory.ReadProcess = aProcesses[0];
                    oMemory.Open();

                    int memoryedit1_Baddress = Addr.ToDec(oMemory.BaseAddressH());
                    int memoryedit1_Address = Addr.ToDec("2FFD98");
                    int[] memoryedit1_Offsets = { 0xC40 };
                    int bytesWritten;
                    byte[] bValue_To_Write = BitConverter.GetBytes(9999);
                    string sWritten_Address = oMemory.PointerWrite((IntPtr)(memoryedit1_Baddress + memoryedit1_Address), bValue_To_Write, memoryedit1_Offsets, out bytesWritten);

                    if (bytesWritten == bValue_To_Write.Length)
                        MessageBox.Show("Wrote 9999 to " + sWritten_Address + "!");
                    else
                        MessageBox.Show("There was an error writing 9999 to " + sWritten_Address + ".");

                    oMemory.CloseHandle();
                }
            }
        }

        private void memoryedit2_Click(object sender, EventArgs e)
        {
            if (memoryedit2.Text == "Hack Off")
            {
                memoryedit2.Text = "Hack On";
                //ENTER CODE TO TURN OFF YOUR HACK HERE IF YOU SO CHOOSE!
            }
            else
            {
                memoryedit2.Text = "Hack Off";
                Process[] aProcesses = Process.GetProcessesByName(Defines.process_name);
                if (aProcesses.Length != 0)
                {
                    oMemory.ReadProcess = aProcesses[0];
                    oMemory.Open();

                    int memoryedit2_Baddress = Addr.ToDec(oMemory.BaseAddressH());
                    int memoryedit2_Address = Addr.ToDec("2FFD98");
                    int[] memoryedit2_Offsets = { 0xC40 };
                    int bytesWritten;
                    byte[] bValue_To_Write = BitConverter.GetBytes(9999);
                    string sWritten_Address = oMemory.PointerWrite((IntPtr)(memoryedit2_Baddress + memoryedit2_Address), bValue_To_Write, memoryedit2_Offsets, out bytesWritten);

                    if (bytesWritten == bValue_To_Write.Length)
                        MessageBox.Show("Wrote 9999 to " + sWritten_Address + "!");
                    else
                        MessageBox.Show("There was an error writing 9999 to " + sWritten_Address + ".");

                    oMemory.CloseHandle();
                }
            }
        }

        private void memoryedit3_Click(object sender, EventArgs e)
        {
            if (memoryedit3.Text == "Hack Off")
            {
                memoryedit3.Text = "Hack On";
                //ENTER CODE TO TURN OFF YOUR HACK HERE IF YOU SO CHOOSE!
            }
            else
            {
                memoryedit3.Text = "Hack Off";
                Process[] aProcesses = Process.GetProcessesByName(Defines.process_name);
                if (aProcesses.Length != 0)
                {
                    oMemory.ReadProcess = aProcesses[0];
                    oMemory.Open();

                    int memoryedit3_Baddress = Addr.ToDec(oMemory.BaseAddressH());
                    int memoryedit3_Address = Addr.ToDec("2FFD98");
                    int[] memoryedit3_Offsets = { 0xC40 };
                    int bytesWritten;
                    byte[] bValue_To_Write = BitConverter.GetBytes(9999);
                    string sWritten_Address = oMemory.PointerWrite((IntPtr)(memoryedit3_Baddress + memoryedit3_Address), bValue_To_Write, memoryedit3_Offsets, out bytesWritten);

                    if (bytesWritten == bValue_To_Write.Length)
                        MessageBox.Show("Wrote 9999 to " + sWritten_Address + "!");
                    else
                        MessageBox.Show("There was an error writing 9999 to " + sWritten_Address + ".");

                    oMemory.CloseHandle();
                }
            }
        }

        private void memadjustable1_TextChanged(object sender, EventArgs e)
        {
            int memadjustable1_Baddress = Addr.ToDec(oMemory.BaseAddressH());
            int memadjustable1_Address = Addr.ToDec("2FFD98");
            int[] memadjustable1_Offsets = { 0xC40 };
            int bytesWritten;
            string sWritten_Address = oMemory.PointerWrite((IntPtr)(memadjustable1_Baddress + memadjustable1_Address),
                                        BitConverter.GetBytes((int)Convert.ToInt32(memadjustable1.Text)),
                                        memadjustable1_Offsets,
                                        out bytesWritten);
        }

        private void memadjustable1freeze_Click(object sender, EventArgs e)
        {
            if (memadjustable1freeze.Text == "Freeze Off")
            {
                memadjustable1freeze.Text = "Freeze On";
                Timer timer = new Timer();
                timer.Tick += new EventHandler(memadjustable1_TextChanged); // Everytime timer ticks, call function
                timer.Interval = (1000) * (10);             // Timer will tick evert 10 seconds
                timer.Enabled = false;                       // Enable the timer
                timer.Stop();                              // Stop the timer
            }
            else
            {
                memadjustable1freeze.Text = "Freeze Off";
                Timer timer = new Timer();
                timer.Tick += new EventHandler(memadjustable1_TextChanged); // Everytime timer ticks, call function
                timer.Interval = (1000) * (10);             // Timer will tick evert 10 seconds
                timer.Enabled = true;                       // Enable the timer
                timer.Start();                              // Start the timer
            }
        }

        private void hMainWindow_FormClosing(object sender, FormClosingEventArgs e) //On Program Close
        {
            if (oMemory.ReadProcess != null) //Process Attached
                oMemory.CloseHandle(); //Close Handle to Process
        }
	}

	class MemoryAPI
	{
		[Flags]
		public enum ProcessAccessType
		{
			PROCESS_TERMINATE = (0x0001),
			PROCESS_CREATE_THREAD = (0x0002),
			PROCESS_SET_SESSIONID = (0x0004),
			PROCESS_VM_OPERATION = (0x0008),
			PROCESS_VM_READ = (0x0010),
			PROCESS_VM_WRITE = (0x0020),
			PROCESS_DUP_HANDLE = (0x0040),
			PROCESS_CREATE_PROCESS = (0x0080),
			PROCESS_SET_QUOTA = (0x0100),
			PROCESS_SET_INFORMATION = (0x0200),
			PROCESS_QUERY_INFORMATION = (0x0400)
		}

		[DllImport("kernel32.dll")]
		public static extern IntPtr OpenProcess(UInt32 dwDesiredAccess, Int32 bInheritHandle, UInt32 dwProcessId);

		[DllImport("kernel32.dll")]
		public static extern Int32 CloseHandle(IntPtr hObject);

		[DllImport("kernel32.dll")]
		public static extern Int32 ReadProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, [In, Out] byte[] buffer, UInt32 size, out IntPtr lpNumberOfBytesRead);

		[DllImport("kernel32.dll")]
		public static extern Int32 WriteProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, [In, Out] byte[] buffer, UInt32 size, out IntPtr lpNumberOfBytesWritten);
	}

	public class Memory
	{
		public Memory()
		{
		}

		public Process ReadProcess
		{
			get
			{
				return m_ReadProcess;
			}
			set
			{
				m_ReadProcess = value;
			}
		}
		private Process m_ReadProcess = null;
		private IntPtr m_hProcess = IntPtr.Zero;

		public void Open()
		{
			MemoryAPI.ProcessAccessType access = MemoryAPI.ProcessAccessType.PROCESS_VM_READ
			| MemoryAPI.ProcessAccessType.PROCESS_VM_WRITE
			| MemoryAPI.ProcessAccessType.PROCESS_VM_OPERATION;
			m_hProcess = MemoryAPI.OpenProcess((uint)access, 1, (uint)m_ReadProcess.Id);
		}

		public void CloseHandle()
		{
			int iRetValue;
			iRetValue = MemoryAPI.CloseHandle(m_hProcess);
			if (iRetValue == 0)
				throw new Exception("CloseHandle Failed");
		}

		public byte[] Read(IntPtr MemoryAddress, uint bytesToRead, out int bytesRead)
		{
			byte[] buffer = new byte[bytesToRead];
			IntPtr ptrBytesRead;
			MemoryAPI.ReadProcessMemory(m_hProcess, MemoryAddress, buffer, bytesToRead, out ptrBytesRead);
			bytesRead = ptrBytesRead.ToInt32();
			return buffer;
		}

		public byte[] PointerRead(IntPtr MemoryAddress, uint bytesToRead, int[] Offset, out int bytesRead)
		{
			int iPointerCount = Offset.Length - 1;
			IntPtr ptrBytesRead;
			bytesRead = 0;
			byte[] buffer = new byte[4]; //DWORD to hold an Address
			int tempAddress = 0;

			if (iPointerCount == 0)
			{
				MemoryAPI.ReadProcessMemory(m_hProcess, MemoryAddress, buffer, 4, out ptrBytesRead);
				tempAddress = Addr.ToDec(Addr.Make(buffer)) + Offset[0]; //Final Address

				buffer = new byte[bytesToRead];
				MemoryAPI.ReadProcessMemory(m_hProcess, (IntPtr)tempAddress, buffer, bytesToRead, out ptrBytesRead);

				bytesRead = ptrBytesRead.ToInt32();
				return buffer;
			}

			for (int i = 0; i <= iPointerCount; i++)
			{
				if (i == iPointerCount)
				{
					MemoryAPI.ReadProcessMemory(m_hProcess, (IntPtr)tempAddress, buffer, 4, out ptrBytesRead);
					tempAddress = Addr.ToDec(Addr.Make(buffer)) + Offset[i]; //Final Address

					buffer = new byte[bytesToRead];
					MemoryAPI.ReadProcessMemory(m_hProcess, (IntPtr)tempAddress, buffer, bytesToRead, out ptrBytesRead);

					bytesRead = ptrBytesRead.ToInt32();
					return buffer;
				}
				else if (i == 0)
				{
					MemoryAPI.ReadProcessMemory(m_hProcess, MemoryAddress, buffer, 4, out ptrBytesRead);
					tempAddress = Addr.ToDec(Addr.Make(buffer)) + Offset[1];
				}
				else
				{
					MemoryAPI.ReadProcessMemory(m_hProcess, (IntPtr)tempAddress, buffer, 4, out ptrBytesRead);
					tempAddress = Addr.ToDec(Addr.Make(buffer)) + Offset[i];
				}
			}

			return buffer;
		}

		public void Write(IntPtr MemoryAddress, byte[] bytesToWrite, out int bytesWritten)
		{
			IntPtr ptrBytesWritten;
			MemoryAPI.WriteProcessMemory(m_hProcess, MemoryAddress, bytesToWrite, (uint)bytesToWrite.Length, out ptrBytesWritten);
			bytesWritten = ptrBytesWritten.ToInt32();
		}

		public string PointerWrite(IntPtr MemoryAddress, byte[] bytesToWrite, int[] Offset, out int bytesWritten)
		{
			int iPointerCount = Offset.Length - 1;
			IntPtr ptrBytesWritten;
			bytesWritten = 0;
			byte[] buffer = new byte[4]; //DWORD to hold an Address
			int tempAddress = 0;

			if (iPointerCount == 0)
			{
				MemoryAPI.ReadProcessMemory(m_hProcess, MemoryAddress, buffer, 4, out ptrBytesWritten);
				tempAddress = Addr.ToDec(Addr.Make(buffer)) + Offset[0]; //Final Address
				MemoryAPI.WriteProcessMemory(m_hProcess, (IntPtr)tempAddress, bytesToWrite, (uint)bytesToWrite.Length, out ptrBytesWritten);

				bytesWritten = ptrBytesWritten.ToInt32();
				return Addr.ToHex(tempAddress);
			}

			for (int i = 0; i <= iPointerCount; i++)
			{
				if (i == iPointerCount)
				{
					MemoryAPI.ReadProcessMemory(m_hProcess, (IntPtr)tempAddress, buffer, 4, out ptrBytesWritten);
					tempAddress = Addr.ToDec(Addr.Make(buffer)) + Offset[i]; //Final Address
					MemoryAPI.WriteProcessMemory(m_hProcess, (IntPtr)tempAddress, bytesToWrite, (uint)bytesToWrite.Length, out ptrBytesWritten);

					bytesWritten = ptrBytesWritten.ToInt32();
					return Addr.ToHex(tempAddress);
				}
				else if (i == 0)
				{
					MemoryAPI.ReadProcessMemory(m_hProcess, MemoryAddress, buffer, 4, out ptrBytesWritten);
					tempAddress = Addr.ToDec(Addr.Make(buffer)) + Offset[i];
				}
				else
				{
					MemoryAPI.ReadProcessMemory(m_hProcess, (IntPtr)tempAddress, buffer, 4, out ptrBytesWritten);
					tempAddress = Addr.ToDec(Addr.Make(buffer)) + Offset[i];
				}
			}

			return Addr.ToHex(tempAddress);
		}

		public int PID()
		{
			return m_ReadProcess.Id;
		}

		public string BaseAddressH()
		{
			return Addr.ToHex(m_ReadProcess.MainModule.BaseAddress.ToInt32());
		}

		public int BaseAddressD()
		{
			return m_ReadProcess.MainModule.BaseAddress.ToInt32();
		}
	}

	public class Addr
	{
		public static string Make(byte[] buffer)
		{
			string sTemp = "";

			for (int i = 0; i < buffer.Length; i++)
			{
				if (Convert.ToInt16(buffer[i]) < 10)
					sTemp = "0" + ToHex(buffer[i]) + sTemp;
				else
					sTemp = ToHex(buffer[i]) + sTemp;
			}

			return sTemp;
		}

		public static bool IsNumeric(string sNumber)
		{
			Regex Match = new Regex(@"^\d+$");
			return Match.IsMatch(sNumber);
		}

		public static string ToHex(int Decimal)
		{
			return Decimal.ToString("X"); //Convert Decimal to Hexadecimal
		}

		public static int ToDec(string Hex)
		{
			return int.Parse(Hex, NumberStyles.HexNumber); //Convert Hexadecimal to Decimal
		}
	}
}
