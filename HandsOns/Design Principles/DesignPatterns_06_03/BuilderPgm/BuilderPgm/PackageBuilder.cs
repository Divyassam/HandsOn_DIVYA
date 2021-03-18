using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPgm
{
    public abstract class PackageBuilder
    {
        public abstract void SetPack();
        public abstract SweetPackage GetPack();
    }


    //Variant 1
    class AdultPack : PackageBuilder
    {
        private SweetPackage sweetObj=new SweetPackage();
        public override void SetPack()
        {
            sweetObj.Sweet = 2;
            sweetObj.Savory = 2;
        }
        public override SweetPackage GetPack()
        {
            Console.Write("Adult Package - ");
            return sweetObj;
        }

    }


    //Variant 1
    class ChildPack : PackageBuilder
    {
        private SweetPackage sweetObj = new SweetPackage();
        public override void SetPack()
        {
            sweetObj.Sweet =2;
            sweetObj.Savory = 1;
        }

        public override SweetPackage GetPack()
        {
            Console.Write("Child Package - ");
            return sweetObj;
        }

    }


    class Director
    {
        public string MakePack(PackageBuilder packBuilder)
        {
            packBuilder.SetPack();
            SweetPackage sweetObj= packBuilder.GetPack();
            if (sweetObj.Savory > 1)
            {
                return sweetObj.Sweet + " sweets, " + sweetObj.Savory + " savories";
            }
            else
            {
                return sweetObj.Sweet + " sweets, " + sweetObj.Savory + " savory";
            }
        }
    }
}
