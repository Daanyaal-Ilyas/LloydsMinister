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
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int AccountNoSimple { get; set; }
        public int SortcodeSimple { get; set; }
        public int BalanceSimple { get; set; }
        public int AccountNoLong { get; set; }
        public int SortcodeLong { get; set; }
        public int BalanceLong { get; set; }
        public int AccountNoCurrent { get; set; }
        public int SortcodeCurrent { get; set; }
        public int BalanceCurrent { get; set; }
        public int Pin { get; set; }

        DB() { }

        DB(int id, string firstName, string lastName, int accountNoSimple, int sortcodeSimple, int balanceSimple, int accountNoLong, int sortcodeLong, int balanceLong, int accountNoCurrent, int sortcodeCurrent, int balanceCurrent, int pin)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            AccountNoSimple = accountNoSimple;
            SortcodeSimple = sortcodeSimple;
            BalanceSimple = balanceSimple;
            AccountNoLong = accountNoLong;
            SortcodeLong = sortcodeLong;
            BalanceLong = balanceLong;
            AccountNoCurrent = accountNoCurrent;
            SortcodeCurrent = sortcodeCurrent;
            BalanceCurrent = balanceCurrent;
            Pin = pin;
        }
    }
}