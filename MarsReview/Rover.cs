using System;
namespace MarsReview
{
    public class Plateau
    {
        private int Plateau_width;
        private int Plateau_length;

        public Plateau(int plateau_width, int plateau_length)
        {
            Plateau_width = plateau_width;
            Plateau_length = plateau_length;
        }

        public int GetPlateau_width()
        {
            return Plateau_width;
        }
        public void SetPlateau_width(int value)
        {
            Plateau_width = value;
        }

        public int GetPlateau_length()
        {
            return Plateau_length;
        }
        public void SetPlateau_length(int value)
        {
            Plateau_length = value;
        }
    }

    public class Rover
    {
        private int coordinate_x;

        private int coordinate_y;

        private char direction;

        
        public Rover() { }
        public Rover(int coordinate_x, int coordinate_y, char direction)
        {
            SetCoordinate_x(coordinate_x);
            SetCoordinate_y(coordinate_y);
            SetDirection(direction);
        }

        public int GetCoordinate_x()
        {
            return coordinate_x;
        }
        public void SetCoordinate_x(int value)
        {
            coordinate_x = value;
        }

        public int GetCoordinate_y()
        {
            return coordinate_y;
        }
        public void SetCoordinate_y(int value)
        {
            coordinate_y = value;
        }

        public char GetDirection()
        {
            return direction;
        }
        public void SetDirection(char value)
        {
            direction = value;
        }

        public void MoveOneUnit(int border_x,int border_y)
        {
            char direction = GetDirection();
            if(direction == 'E')
            {
                if (coordinate_x != border_x) coordinate_x++;

            }
            else if(direction == 'N')
            {
                if(coordinate_y != border_y)    coordinate_y++;
            }
            else if (direction == 'W')
            {
                if (coordinate_x != 0) coordinate_x--;
            }
            else
            {
                if (coordinate_y != 0) coordinate_y--;
            }
        }
        public void ChangeDirection(char changeDirection)
        {
            char temp_direction = GetDirection();
            if(changeDirection == 'L')
            {
                if(temp_direction == 'E')
                {
                    SetDirection('N');
                }
                else if(temp_direction == 'N')
                {
                    SetDirection('W');

                }
                else if (temp_direction == 'W')
                {
                    SetDirection('S');

                }
                // if (temp_direction == 'S')
                else
                {
                    SetDirection('E');
                }
            }
            else
            {
                if (temp_direction == 'E')
                {
                    SetDirection('S');
                }
                else if (temp_direction == 'N')
                {
                    SetDirection('E');

                }
                else if (temp_direction == 'W')
                {
                    SetDirection('N');

                }
                //if (temp_direction == 'S')
                else
                {
                    SetDirection('W');

                }
            }
        }
        public void TakeAction(string move, Plateau plateau)
        {
            int border_x = plateau.GetPlateau_width();
            int border_y = plateau.GetPlateau_length();

            char[] move_char = move.ToCharArray();
            for(int i = 0; i < move_char.Length; i++)
            {
                if (move_char[i] == 'L' || move_char[i] == 'R')
                {
                    ChangeDirection(move[i]);
                }
                else if (move_char[i] == 'M')
                {
                    MoveOneUnit(border_x,border_y);
                }
                else break;
            }
        }

        public void ShowCoordinate()
        {
            Console.WriteLine($"{coordinate_x} {coordinate_y} {direction}");
        }
    }
}
