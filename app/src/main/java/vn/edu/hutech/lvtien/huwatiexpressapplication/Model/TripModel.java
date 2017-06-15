package vn.edu.hutech.lvtien.huwatiexpressapplication.Model;

import com.google.gson.annotations.SerializedName;

import java.util.List;

public class TripModel {

    @SerializedName("Trip")
    public List<Trip> Trip;

    public static class Trip {
        @SerializedName("Trip_Id")
        public int Trip_Id;
        @SerializedName("Bus_Id")
        public int Bus_Id;
        @SerializedName("Company_Name")
        public String Company_Name;
        @SerializedName("Bus_Type_Name")
        public String Bus_Type_Name;
        @SerializedName("Start_Point")
        public String Start_Point;
        @SerializedName("Def_Point")
        public String Def_Point;
        @SerializedName("Start_Time")
        public String Start_Time;
        @SerializedName("Blank")
        public int Blank;
        @SerializedName("Price")
        public int Price;
    }
}
