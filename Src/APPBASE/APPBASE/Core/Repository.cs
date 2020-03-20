using System;

namespace APPBASE.Models
{
    public abstract class Repository
    {

        protected int? ID { get; set; }
        protected Boolean isERR { get; set; }
        protected string ERRMSG { get; set; }

        public abstract void Create();
        public abstract void Update();
        public abstract void Delete(int? id);
        public abstract void Commit(int? parID, Boolean parIsError, string parErrMsg);

        public int? getId()
        {
            return this.ID;
        }

        public Boolean getStatus()
        {
            return this.isERR;
        }

        public string getResultMsg()
        {
            return this.ERRMSG;
        }

    } //End class

} //End namespace
