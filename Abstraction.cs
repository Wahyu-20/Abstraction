using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
 // Compiler version 4.0, .NET Framework 4.5


 namespace AbstractClass
 {
   public class Program
   {
     public static void Main(string[] args)
     {
        Console.WriteLine();
       
       Console.WriteLine("==== OS ====");
       
       Console.WriteLine();
       
       ACOperatingSystem os;
       
       os = new MacOS();
       os.pembuat();
       os.kernel();
       os.jenis();
       
       Console.WriteLine();
       
       os = new Linux();
       os.pembuat();
       os.kernel();
       os.jenis();
       
       
       Console.WriteLine();
       
       Console.WriteLine("==== OS ====");
       
       Console.WriteLine();
       
       Os1 Os;
       
       Os = new MacOS1();
       Os.info();
       Os.jenis();
       Os.keuntungan();
       
       Console.WriteLine();
       
       Os = new Linux1();
       Os.info();
       Os.jenis();
       Os.keuntungan();
     }
   }
   
   // Abstract Class 
   public abstract class ACOperatingSystem {
     public abstract void pembuat();
     public abstract void kernel();
     public abstract void jenis();
   }
   
   public class MacOS : ACOperatingSystem {
     public override void pembuat() {
       Console.WriteLine("Manufaktur : Apple ");
     }
     
     public override void kernel() {
       Console.WriteLine("Kernel     : Darwin ");
     }
     
     public override void jenis() {
       Console.WriteLine("Jenis      : Closed Source ");
     }
   }
   
   public class Linux : ACOperatingSystem {
     public override void pembuat() {
       Console.WriteLine("Manufaktur : Distro Linux ");
     }
     
     public override void kernel() {
       Console.WriteLine("Kernel     : Linux ");
     }
     
     public override void jenis() {
       Console.WriteLine("Jenis      : Open Source ");
     }
   }
   
   public interface Os1{
     void info();
     void jenis();
     void keuntungan();
   }
   
  public class MacOS1 : Os1 {
     public void info() {
       Console.WriteLine("Ciri Khas MacOS : ");
     }
   
     public void jenis() {
       Console.WriteLine("- Jenis Os Closed Source");
     }
     public void keuntungan() {
       Console.WriteLine("- Sistem Pertahanan Kuat");
     }
     
   } 
   
   public class Linux1 : Os1 {
     public void info() {
       Console.WriteLine("Ciri Khas Linux : ");
     }
     public void jenis() {
       Console.WriteLine("- Jenis Os Open Source");
     }
     public void keuntungan() {
       Console.WriteLine("- Kecepatan Access Tinggi");
     }
   } 
   
 }