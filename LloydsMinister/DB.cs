using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace LloydsMinister
{
    class DB
    {
        [PrimaryKey,AutoIncrement]

        public int Id { get; set; }

    }
}