using Infrastructure;
using Infrastructure.Base;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class AnnualPermission : PermissionBase , IPermissionRequiredApprove
    {
        public override BaseOperationResult PermissionComplete(AddPermissionModel request)
        {
            var completeResult = PermissionCompleteBefore(request);

            if (!completeResult.IsSuccess)
                return completeResult;

            // TODO :  Yıllık izin için yapılacak olan operasyonlar

            completeResult = SendToManagerForApprove(request);

            completeResult = PermissionCompleteAfter(request);

            return completeResult;
        }


        public override BaseOperationResult PermissionCompleteAfter(AddPermissionModel request)
        {
            BaseOperationResult result = new BaseOperationResult();

            // TODO :  Yıllık izin verildikten sonra bilgilendirmeler , mailler vs.

            return result;

        }
        public override BaseOperationResult PermissionCompleteBefore(AddPermissionModel request)
        {
            BaseOperationResult result = new BaseOperationResult();

            // TODO :  Yıllık izin için kullanıcı özelinde validasyonlar vs.

            return result;
        }

        public BaseOperationResult SendToManagerForApprove(AddPermissionModel request)
        {
            BaseOperationResult result = new BaseOperationResult();

            // TODO :  Yıllık izin için IPermissionRequiredApprove gelen yönetici onay zorunluğuna göre yapılacak onay yönlendirmeleri vs.  
            // Onay mekanizmasına tabi tutulacak izin için bu interface implemente edilecek. (Onay sadece işlem örneği, sonuş itibari ile farklı bir süreç işleyecek operasyonalrda olabilir.)

            return result;
        }
    }
}
