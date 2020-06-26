using Infrastructure;
using Infrastructure.Base;
using Model;

namespace Business
{
    public class ExcusePermission : PermissionBase
    {
        public override BaseOperationResult PermissionComplete(AddPermissionModel request)
        {
            var permissionResultBefore = PermissionCompleteBefore(request);

            if (!permissionResultBefore.IsSuccess)
                return permissionResultBefore;
           
            // TODO :  Mazeret izni için yapılacak olan operasyonlar

            var permissionResultAfter = PermissionCompleteAfter(request);

            return permissionResultBefore;
        }


        public override BaseOperationResult PermissionCompleteAfter(AddPermissionModel request)
        {
            BaseOperationResult result = new BaseOperationResult();

            // TODO :  Mazeret izni verildikten sonra bilgilendirmeler , mailler vs.

            return result;


        }
        public override BaseOperationResult PermissionCompleteBefore(AddPermissionModel request)
        {
            BaseOperationResult result = new BaseOperationResult();

            // TODO :  Mazeret izni için kullanıcı özelinde validasyonlar vs.

            return result;
        }
    }
}
