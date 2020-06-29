using System;
using System.Collections.Generic;
using System.Text;
using PolymorphCollection.ClassInduk;

namespace PolymorphCollection.ClassAnak
{
    class KaryawanTetap : Karyawan
    {
        public double GajiBulanan { get; set; }
        public override double Gaji() => GajiBulanan;
    }
}
