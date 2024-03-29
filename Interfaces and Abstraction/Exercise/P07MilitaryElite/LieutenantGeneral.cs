﻿using MilitaryElite.Models.Interfaces;
using System.Text;

namespace MilitaryElite
{
    public class LieutenantGeneral : Private, ILieutenantGeneral
    {
        public LieutenantGeneral(int id, string firstName, string lastName, decimal salary, IReadOnlyCollection<IPrivate> privates) : base(id, firstName, lastName, salary)
        {
            Privates = privates;
        }

        public IReadOnlyCollection<IPrivate> Privates { get; private set; }

        public override string ToString()
        {
            StringBuilder sb = new();
            sb.AppendLine($"{base.ToString()}");
            sb.AppendLine("Privates:");
            foreach (var pravet in Privates)
            {
                sb.AppendLine($" {pravet.ToString()}");

            }

            return sb.ToString().TrimEnd();
        }
    }
}
