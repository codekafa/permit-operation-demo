using Infrastructure.Base;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public abstract class PermissionBase : IPermission
    {
        public abstract BaseOperationResult PermissionComplete(AddPermissionModel request);

        public abstract BaseOperationResult PermissionCompleteAfter(AddPermissionModel request);

        public abstract BaseOperationResult PermissionCompleteBefore(AddPermissionModel request);

    }
}
