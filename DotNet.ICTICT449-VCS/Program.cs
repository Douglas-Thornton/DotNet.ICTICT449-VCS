﻿using System;

class Program
{
    static void Main(string[] args)
    {
        bool running = true;

        while (running)
        {

            int? choice = null;

            while (running)
            {
				Console.WriteLine("Select a flower from the list:");
				Console.WriteLine("1. Rose");
				Console.WriteLine("2. Sunflower");
				Console.WriteLine("3. Daisy");
				Console.WriteLine("4. Tulip");
                Console.WriteLine("5. Close application");
				Console.Write("Enter your choice (1-5): ");

				if (!int.TryParse(Console.ReadLine(), out int parsedValue)) 
                {
                    choice = null;
                }
                else 
                {
					choice = parsedValue;
				}
				if (choice != null)
                {
                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine(@"
    _,--._.-,
   /\_r-,\_ )
.-.) _;='_/ (.;
 \ \'     \/S )
  L.'-. _.'|-'
 <_`-'\'_.'/
   `'-._( \
    ___   \\,      ___
    \ .'-. \\   .-'_. /
     '._' '.\\/.-'_.'
        '--``\('--'
              \\
              `\\,
                \|");
                            break;
                        case 2:
                            Console.WriteLine(@"      ░░                                      ▓▓                                          
                                            ▓▓▓▓▓▓                                        
                                        ▓▓▓▓░░░░▓▓                                        
    ▓▓▓▓▓▓▓▓▓▓                        ▓▓░░  ░░▓▓░░▓▓▓▓                        ▓▓▓▓▓▓      
      ▓▓░░▓▓░░▓▓▓▓▓▓▓▓▓▓▓▓            ▓▓▓▓      ▓▓░░░░▓▓            ▓▓▓▓▓▓▓▓▓▓▓▓▓▓        
        ▓▓░░░░░░░░▓▓▓▓░░░░▓▓▓▓░░░░  ▓▓▓▓▓▓  ░░░░  ▓▓▒▒  ░░    ▓▓▓▓▓▓▓▓▒▒▒▒▓▓▒▒▓▓▓▓        
        ▒▒▒▒░░▒▒░░▒▒▒▒░░▒▒▒▒▒▒      ░░▒▒░░        ▒▒░░      ▒▒▒▒▒▒▒▒▒▒░░░░▒▒▒▒▒▒▒▒        
          ▒▒░░▒▒▒▒░░░░░░▒▒▒▒▒▒        ░░          ▒▒        ▒▒▒▒░░░░▒▒░░▒▒▒▒▒▒░░▓▓        
          ▓▓░░░░▓▓▓▓        ▓▓░░            ░░              ░░░░░░░░▓▓░░▓▓░░░░░░▓▓        
          ▓▓▒▒░░░░▓▓▓▓          ░░    ░░    ░░░░            ░░        ▒▒▓▓▓▓░░▓▓          
          ▓▓▒▒▒▒▒▒▒▒▓▓░░  ░░░░  ░░░░░░░░░░░░░░░░    ░░░░░░░░░░░░░░▒▒▒▒▓▓▒▒▒▒░░▓▓          
          ▒▒░░▒▒▒▒▒▒▒▒▒▒▒▒      ░░░░░░░░░░░░░░░░  ░░░░░░░░░░      ░░░░░░░░░░▒▒▒▒          
          ▒▒░░░░░░░░░░░░▒▒  ░░    ░░░░░░░░▓▓░░▓▓  ░░░░░░░░            ░░░░░░▒▒░░          
          ░░▒▒░░        ░░░░░░░░░░  ░░░░▓▓▓▓▓▓▓▓▓▓░░░░░░░░          ▒▒▒▒░░▒▒░░            
            ░░▒▒░░░░    ░░░░░░░░░░░░▓▓▓▓▓▓▓▓▓▓▓▓██▓▓▓▓░░        ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒        
                ▓▓░░░░          ██▓▓██████▓▓▓▓▓▓████▓▓████      ░░░░░░░░  ░░░░▓▓▓▓        
                ░░    ░░░░░░░░██▓▓████▓▓▓▓▓▓▓▓▓▓▓▓████▓▓████░░░░░░    ░░░░  ░░░░▓▓▓▓▓▓    
                            ░░▓▓████▓▓██████████▓▓▓▓████▓▓░░              ▓▓░░▒▒░░▓▓▓▓▓▓▓▓
                              ░░████▓▓████████████▓▓▓▓██▓▓                    ▓▓▓▓░░▓▓▓▓  
                    ░░░░░░░░▓▓▓▓▓▓▒▒████████▓▓██▓▓▒▒▒▒▓▓▓▓░░░░░░░░        ░░▒▒▒▒▒▒▒▒▒▒░░  
        ▒▒░░░░░░░░░░░░░░░░░░▒▒██▓▓▓▓▓▓▓▓██████████▓▓▓▓████░░░░░░░░░░░░░░░░▒▒▓▓▒▒▒▒▓▓░░    
      ▒▒░░░░░░  ░░░░  ░░  ░░░░▓▓▒▒▒▒▓▓██████████▓▓▒▒▓▓▓▓▓▓        ░░  ░░  ░░░░░░▒▒▒▒      
    ▓▓░░                      ██▓▓██▓▓██████████▓▓██▓▓▓▓████░░░░░░      ▓▓▓▓░░▓▓▓▓        
    ▓▓      ▓▓                ████▓▓██████████▓▓██▓▓▓▓▓▓██    ░░  ░░▓▓▓▓▓▓▓▓▓▓            
  ▒▒░░▒▒▒▒░░▒▒▒▒▒▒            ░░██▒▒▒▒▓▓▓▓▒▒▓▓▓▓▒▒▓▓▒▒▓▓░░        ░░  ░░▒▒                
▓▓▓▓▓▓░░░░▓▓░░                ████████▓▓██▓▓██▓▓██▓▓██████          ░░                    
    ▓▓▓▓░░░░              ░░░░░░████▓▓▓▓▓▓▓▓▓▓▓▓▓▓████  ░░░░░░░░                          
        ▓▓▓▓            ░░░░      ████████▓▓██▓▓██  ░░░░    ░░      ▓▓                    
                  ░░░░░░░░      ░░░░░░░░░░      ░░      ░░    ░░░░░░▒▒▒▒                  
            ▓▓░░░░▓▓░░          ░░        ░░    ░░░░      ░░          ▓▓▓▓                
          ▓▓░░░░▓▓░░          ░░          ░░░░      ░░      ▓▓░░        ▓▓▓▓              
          ▓▓░░▓▓░░              ░░          ░░      ░░      ▓▓░░▓▓░░░░░░░░▓▓              
        ▓▓▓▓░░▓▓▓▓                                    ░░      ▓▓▓▓░░░░░░░░▓▓              
        ▓▓░░▓▓░░▓▓        ▓▓                          ░░        ▓▓▓▓░░▓▓░░░░▓▓            
        ▓▓░░░░▓▓▓▓    ▓▓▓▓▓▓                            ░░      ░░▓▓▓▓▓▓▓▓░░▓▓            
        ▓▓░░▓▓▓▓▓▓▓▓▓▓▓▓░░▓▓    ▓▓              ░░      ▓▓░░░░▓▓▓▓░░░░░░░░▓▓▓▓            
        ▓▓▓▓░░▓▓░░░░▓▓▓▓▓▓░░  ▓▓▓▓    ▓▓      ▓▓▒▒▓▓▓▓  ▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓░░▓▓▓▓            
        ░░▒▒░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒  ▒▒▒▒░░  ▒▒▒▒░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░▒▒░░            
        ▒▒▒▒░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░▒▒░░▒▒▒▒▒▒  ▒▒▒▒░░░░░░▒▒░░▒▒░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒              
        ▓▓░░▒▒▒▒▓▓▓▓▓▓▒▒░░░░▒▒▓▓░░░░▓▓▓▓      ▓▓▓▓░░░░░░▓▓░░░░░░▓▓▓▓▓▓▓▓▓▓▓▓              
      ▓▓▓▓▓▓          ▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓          ▓▓▓▓▓▓▓▓▓▓░░▒▒░░░░▓▓░░▓▓░░▓▓              
      ▒▒░░░░          ░░░░  ░░  ░░░░░░          ░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░▒▒░░▒▒░░▒▒▒▒            
      ░░                                          ░░    ░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░▒▒            
                                                                ▓▓▓▓▓▓▓▓▓▓▓▓▓▓            
                                                                          ▓▓▓▓▓▓          
");
                            break;
                        case 3:
                            Console.WriteLine(@"⠀⠀                           
                             .-.
                       __   /   \   __
                      (  `'.\   /.'`  )
                       '-._.(;;;)._.-'
                       .-'  ,`""`,  '-.
                      (__.-'/   \'-.__)/)_
                            \   /\    / / )
                             '-'  |   \/.-')
                             ,    | .'/\'..)
                             |\   |/  | \_)
                             \ |  |   \_/
                              | \ /
                               \|/    _,
                                /  __/ /
                               | _/ _.'
                               |/__/
                                \");
                            break;
                        case 4:
                            Console.WriteLine(@"
         .-==-.
        /{.=-.}\
       | / .  \ |
       |;   :  :|
       \(   :  )/
        `._'__.'
      |\   ||
      \ \  ||
       | | ||
       | | ||   /|
       \  \||  / /
        \ ||| | |
         | || | |
          \||/  /
           ||| /
           || |
           ||/
           ||");
                            break;
                        case 5:
                            Console.WriteLine("Thanks for checking the ascii");
                            running = false;
                            Console.ReadKey();
                            break;
                    }

                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Choice invalid. Please only enter a number from the list.");
                }
            }
        }
    }
}