using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfRespPgm
{
    //Handler Interface
    public interface ILeaveRequestHandler
    {
        public ILeaveRequestHandler nextHandler { get; set; }
        public void HandleRequest(int leaveDays);
    }


    //Concrete Handler 1
    public class Supervisor : ILeaveRequestHandler
    {
        public ILeaveRequestHandler nextHandler{ get; set; }
        public Supervisor() { nextHandler = new ProjectManager(); }

        public void HandleRequest(int leaveDays)
        {
            if (leaveDays < 3)
            {
                Console.WriteLine("Leave Approved by Supervisor");
            }
            else
            {
                Console.WriteLine("Supervisor Forwarded to Project Manager");
                nextHandler.HandleRequest(leaveDays);
            }

        }
    }


    //Concrete Handler 2
    public class ProjectManager : ILeaveRequestHandler
    {
        public ILeaveRequestHandler nextHandler { get; set; }
        public ProjectManager() { nextHandler = new HR(); }
        public void HandleRequest(int leaveDays)
        {
            if (leaveDays < 5)
            {
                Console.WriteLine("Leave Approved by Project Manager");
            }
            else
            {
                Console.WriteLine("Project Manager Forwarded to HR");
                nextHandler.HandleRequest(leaveDays);
            }

        }
    }


    //Concrete Handler 3
    public class HR : ILeaveRequestHandler
    {
        public ILeaveRequestHandler nextHandler { get; set; }
        public void HandleRequest(int leaveDays)
        {
            Console.WriteLine("Leave Approved by HR Manager");

        }
    }


}
