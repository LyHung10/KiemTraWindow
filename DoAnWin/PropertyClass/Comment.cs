using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnWin.PropertyClass
{
    public class Comment : Job
    {
        private string comment;
        private int rate;
        private DateTime finishDay;

        public Comment() { }

        public Comment(string idUser, string nameUser, string idWorker, string nameWorker,string idWork, string comment, int Rate, DateTime finishDay):base(idUser, nameUser, idWorker, nameWorker, idWork)
        {
            this.comment = comment;
            this.rate = Rate;
            this.finishDay = finishDay;
        }

        public string Comment1 { get => comment; set => comment = value; }
        public int Rate1 { get => rate; set => rate = value; }
        public DateTime FinishDay { get => finishDay; set => finishDay = value; }
    }
}
