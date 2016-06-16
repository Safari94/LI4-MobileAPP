namespace Mobile_APP
{
    public class Cordenadas
    {
        private double latitude;
        private double longitude;

        public Cordenadas() {
            this.latitude = 0.0f;
            this.longitude = 0.0f;
        }

        public Cordenadas(double lgtd, double lat) {

            this.longitude = lgtd;
            this.latitude = lat;

        }

        public double Latitude { get; set; }
        public double Longitude { get; set; }
    }
}