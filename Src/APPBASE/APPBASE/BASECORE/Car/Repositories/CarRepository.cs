using System;
using APPBASE.Helpers;

namespace APPBASE.Models
{
    public class CarRepository : Repository
    {
        protected Car oModel;

        public CarRepository(BaseEntity parModel, int? parLastID)
        {
            this.oModel = (Car)parModel;
            this.oModel.LAST_ID = parLastID;
        }

        public override void Commit(int? parID, Boolean parIsError, string parErrMsg)
        {
            this.ID = parID;
            this.isERR = parIsError;
            this.ERRMSG = parErrMsg;
        }

        public override void Create()
        {
            this.oModel.setID(hlpFlags_CRUDOption.CREATE);
            this.oModel.incrementID(this.oModel.LAST_ID);
            this.Commit(this.oModel.ID, true, "Create Success");
        }

        public override void Delete(int? id)
        {
            this.oModel.ID = id;
            this.Commit(this.oModel.ID, true, "Delete Success");
        }

        public override void Update()
        {
            this.Commit(this.oModel.ID, true, "Update Success");
        }

        public void tambahan()
        {

        }

    } //End class

} //End namespace
