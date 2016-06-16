using System;

namespace Mobile_APP
{
    public class Cordenadas
    {
        private double latitude { get; set; }
        private double longitude { get; set; }

        public Cordenadas() {
            this.latitude = 0.0f;
            this.longitude = 0.0f;
        }

        public Cordenadas(double lgtd, double lat) {

            this.longitude = lgtd;
            this.latitude = lat;

        }

        public String toString() {

            return "Latitude: " + latitude + ", Longitude: " + longitude;
        }

   
    }
}