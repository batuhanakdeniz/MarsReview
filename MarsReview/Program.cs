using System;
using System.Collections.Generic;
using System.Linq;

namespace MarsReview
{

    class Program
    {
 
        static void Main(string[] args)
        {
            String Plateau_width_length_input = Console.ReadLine();
            int[] Plateau_width_length = Plateau_width_length_input.Split(' ').Select(int.Parse).ToArray();
            Plateau plateau = new Plateau(Plateau_width_length[0], Plateau_width_length[1]);
            List<Rover> rovers = new List<Rover>();
            String Rover_coordinates_input;
            List<string> Rover_move = new List<string>();
            int Rover_coordinates_x = 0;
            int Rover_coordinates_y = 0;
            char Rover_coordinates_direction = ' ';
            while (true)
            {
                Rover_coordinates_input = Console.ReadLine();
                if (string.IsNullOrEmpty(Rover_coordinates_input)) break;
                String[] Rover_coordinates = Rover_coordinates_input.Split(' ');

                Rover_coordinates_x = Convert.ToInt32(Rover_coordinates[0]);
                Rover_coordinates_y = Convert.ToInt32(Rover_coordinates[1]);
                Rover_coordinates_direction = char.Parse(Rover_coordinates[2]);

                string Rover_move_input = Console.ReadLine();
                Rover_move.Add(Rover_move_input);
                rovers.Add( new Rover(Rover_coordinates_x, Rover_coordinates_y, Rover_coordinates_direction));
            }

            int y = 0;
            foreach (Rover aRover in rovers)
            {
                aRover.TakeAction(Rover_move[y], plateau);
                aRover.ShowCoordinate();
                y++;
            }

            string wait = Console.ReadLine();

        }
    }

}
