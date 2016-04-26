using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelKlasserEksamen
{
   public class Bookinger
    {
       public int Id { get; set; }
       public DateTime DateFrom { get; set; }
       public DateTime DateTo { get; set; }
       public int DeltagerId { get; set; }
       public int KursusId { get; set; }

       public Bookinger(int id, DateTime dateFrom, DateTime dateTo, int deltagerId, int kursusId)
       {
           Id = id;
           DateFrom = dateFrom;
           DateTo = dateTo;
           DeltagerId = deltagerId;
           KursusId = kursusId;
       }

       public Bookinger()
       {
           
       }
    }
}
