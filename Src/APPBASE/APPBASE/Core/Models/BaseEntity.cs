using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using APPBASE.Helpers;

namespace APPBASE.Models
{
    public abstract class BaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int? ID { get; set; }
        public int? LAST_ID { get; set; }

        public void setID(int? pnCRUD_Option)
        {
            if (pnCRUD_Option == hlpFlags_CRUDOption.CREATE)
            {
                this.ID = 0; //HACK: (Akal2an untuk mancing autoincremental field)
            } //End if

        } //End method

        public void incrementID(int? parLastID)
        {
            this.ID = parLastID++;
            this.LAST_ID = this.ID;
        } //End method

    } //End class

} //End namespace
