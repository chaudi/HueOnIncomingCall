
namespace HueOnIncomingCall.Hue
{
    public class Light
    {
        public string Id { get; set; }
        public int[] XY { get; set; }
        public string Name { get; set; }

        public Light()
        {
            XY = new int[2];
        }
    }
}