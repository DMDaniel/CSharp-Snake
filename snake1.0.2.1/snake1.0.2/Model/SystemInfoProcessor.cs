using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

namespace snake1._0._2.Model
{
    class SystemInfoProcessor
    {
        //// Import the SYSTEM_POWER_STATUS definition
        //[StructLayout(LayoutKind.Sequential)]
        //struct SYSTEM_POWER_STATUS
        //{

        [DllImport("kernel32.dll", SetLastError = true)]
        static extern bool GetSystemTimes(out System.Runtime.InteropServices.ComTypes.FILETIME lpIdleTime, out  System.Runtime.InteropServices.ComTypes.FILETIME lpKernelTime, out  System.Runtime.InteropServices.ComTypes.FILETIME lpUserTime);

        private TimeSpan sysIdleOldTs;
        private TimeSpan sysKernelOldTs;
        private TimeSpan sysUserOldTs;

        private Double cpuUsage;

        public SystemInfoProcessor()
        {
            this.cpuUsage = 0;
        }

        public Double CpuUsage
        {
            get { return this.cpuUsage; }
        }

        public void GetCPUusage()
        {
            System.Runtime.InteropServices.ComTypes.FILETIME sysIdle, sysKernel, sysUser;

            if (GetSystemTimes(out sysIdle, out sysKernel, out sysUser))
            {
                TimeSpan sysIdleTs = GetTimeSpanFromFileTime(sysIdle);
                TimeSpan sysKernelTs = GetTimeSpanFromFileTime(sysKernel);
                TimeSpan sysUserTs = GetTimeSpanFromFileTime(sysUser);

                TimeSpan sysIdleDifferenceTs = sysIdleTs.Subtract(this.sysIdleOldTs);
                TimeSpan sysKernelDifferenceTs = sysKernelTs.Subtract(this.sysKernelOldTs);
                TimeSpan sysUserDifferenceTs = sysUserTs.Subtract(this.sysUserOldTs);

                this.sysIdleOldTs = sysIdleTs;
                this.sysKernelOldTs = sysKernelTs;
                this.sysUserOldTs = sysUserTs;

                //TimeSpan system = sysKernelDifferenceTs.Add(sysUserDifferenceTs);
                //this.cpuUsage = (((system.Subtract(sysIdleDifferenceTs).TotalMilliseconds) * 100) / system.TotalMilliseconds);

                TimeSpan totaltime = sysKernelDifferenceTs.Add(sysUserDifferenceTs);
                totaltime = totaltime.Add(sysIdleDifferenceTs);
                //this.cpuUsage = 100 - (sysIdleDifferenceTs.TotalMilliseconds * 100) / totaltime.TotalMilliseconds;
                this.cpuUsage = (int)(((sysKernelDifferenceTs.Add(sysUserDifferenceTs).Subtract(sysIdleDifferenceTs).TotalMilliseconds) * 100.00) / sysKernelDifferenceTs.Add(sysUserDifferenceTs).TotalMilliseconds);



                if (this.cpuUsage < 0)
                {
                    this.cpuUsage = this.cpuUsage * (-1);
                }

            }
        }

        private static TimeSpan GetTimeSpanFromFileTime(System.Runtime.InteropServices.ComTypes.FILETIME time)
        {
            return TimeSpan.FromMilliseconds((((ulong)time.dwHighDateTime << 32) + (uint)time.dwLowDateTime) * 0.000001);
        }
    }
}
