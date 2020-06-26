using Data.IoC;
using Infrastructure.Base;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PermissionProject
{
    class Program
    {
        static void Main(string[] args)
        {
            var permissionType = IoCManager.IoCUtil.ResolveNamed<IPermission>("Hourly");
            var result = permissionType.PermissionComplete(new AddPermissionModel { EndDate = DateTime.Now.AddDays(2), PermissionType = "Hourly", StartDate = DateTime.Now.AddDays(1), UserId = 1 });
            Console.ReadLine();
        }
    }
}
