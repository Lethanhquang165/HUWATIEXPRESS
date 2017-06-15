package vn.edu.hutech.lvtien.huwatiexpressapplication.View.ListTrips;

import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;

import vn.edu.hutech.lvtien.huwatiexpressapplication.R;
import vn.edu.hutech.lvtien.huwatiexpressapplication.View.Util.ActivityUtils;

public class TripsActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_trips);

        TripsFragment tripsFragment = (TripsFragment)
                getSupportFragmentManager().findFragmentById(R.id.contentFrame);
        if(tripsFragment == null){
            tripsFragment = TripsFragment.newInstance();
            ActivityUtils.addFragmentToActivity(
                    getSupportFragmentManager(),
                    tripsFragment,
                    R.id.contentFrame
            );
        }
    }
}
