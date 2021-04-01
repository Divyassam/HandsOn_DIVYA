using System;

namespace ChainOfRespPgm
{
    class Program
    {
        static void Main(string[] args)
        {
            LeaveRequest leaveRequest = new LeaveRequest();
            Supervisor supervisor = new Supervisor();

            leaveRequest.Employee = "Max";
            leaveRequest.LeaveDays = 4;
            supervisor.HandleRequest(leaveRequest.LeaveDays);
            Console.WriteLine("---------------------------------------------------------\n");

            leaveRequest.Employee = "Tiya";
            leaveRequest.LeaveDays = 2;
            supervisor.HandleRequest(leaveRequest.LeaveDays);
            Console.WriteLine("---------------------------------------------------------\n");

            leaveRequest.Employee = "George";
            leaveRequest.LeaveDays = 10;
            supervisor.HandleRequest(leaveRequest.LeaveDays);
            Console.WriteLine("---------------------------------------------------------\n");


        }
    }
}
