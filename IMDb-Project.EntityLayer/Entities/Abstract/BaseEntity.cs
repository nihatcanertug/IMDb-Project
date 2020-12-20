using IMDb_Project.EntityLayer.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMDb_Project.EntityLayer.Entities.Abstract
{
    public abstract class BaseEntity<T> // We assigned a type of<T> type to our BaseEntity abstract class.
    {
        public abstract T Id { get; set; }

        private DateTime _createDate = DateTime.Now;// When data was entered we encapsulated the created time equal Now.
        public DateTime CreateDate { get => _createDate; set => _createDate = value; }
        public DateTime? ModifiedDate { get; set; } // It can be Null so we use ? for entity.

        public DateTime? PassivedDate { get; set; }

        private Status _status = Status.Active; // When data was entered, we actively accepted the status of that data
        public Status Status { get=>_status; set=>_status=value; }
    }
}
