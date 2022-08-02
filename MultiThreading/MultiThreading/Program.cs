// See https://aka.ms/new-console-template for more information

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultithreadEmpPayroll
{
    public class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome To Multi Threading Problem");
        }
    }
}

//With Thread Process The Employees details are not added as sequential manner.
/*
 Employee Being Added :Eren
Employee added : Eren
Employee Being Added :Levi
Employee added : Levi
Employee Being Added :Mikasa
Employee added : Mikasa
Employee Being Added :Naruto
Employee added : Naruto
Employee Being Added :Sasuke
Employee added : Sasuke
Employee Being Added :Madara
Employee added : Madara
Employee Being Added :Luffy
Employee added : Luffy
Employee Being Added :Zorro
Employee added : Zorro
Employee Being Added :Nami
Employee added : Nami
Employee Being Added :Naruto
Employee added : Naruto
System.Collections.Generic.List`1[MultithreadEmpPayroll.EmpData]
Duration Without thread: 00:00:00.0006645
Employee Being Added :Mikasa
Employee Being Added :Eren
Employee added : Mikasa
Employee added : Eren
Employee Being Added :Naruto
Employee added : Naruto
Employee Being Added :Levi
Employee added : Levi
Employee Being Added :Sasuke
Employee added : Sasuke
Employee Being Added :Luffy
Employee added : Luffy
Employee Being Added :Zorro
Employee Being Added :Madara
Employee added : Zorro
Employee Being Added :Nami
Employee added : Madara
Employee added : Nami
Employee Being Added :Naruto
Employee added : Naruto
17
Duration With thread: 00:00:00.0006645
 */
