namespace Mobile_APP
{
    public class Cordenadas
    {
        private float latitude;
        private float longitude;

        public Cordenadas() {
            this.latitude = 0.0f;
            this.longitude = 0.0f;
        }

        public Cordenadas(float lgtd, float lat) {

            this.longitude = lgtd;
            this.latitude = lat;

        }

        public float Latitude { get; set; }
        public float Longitude { get; set; }
    }
}