namespace Buildings
{

    public class Building
    {
        private double _height;
        private int _floors;

        public Building(double height, int floors) 
        {
            _height = height;
            _floors = floors;
        }
        public Building(int floors) : this ((floors * 3), floors)
        {}
        public double GetFloorMaxSize()
        {
            return _height / _floors;
        }
        public int GetFloorCount()
        {
            return _floors;
        }
        public double GetSize()
        {
            return _height;
        }
    }

    public static class Program
    {
        public static void Main()
        {
            Building building = new Building(5);
            double height = building.GetSize();
            System.Console.WriteLine(height);
            double max_floor_size = building.GetFloorMaxSize();
            System.Console.WriteLine(max_floor_size);
        }
    }
}