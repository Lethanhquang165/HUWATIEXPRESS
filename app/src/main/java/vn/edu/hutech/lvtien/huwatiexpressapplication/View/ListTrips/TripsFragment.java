package vn.edu.hutech.lvtien.huwatiexpressapplication.View.ListTrips;


import android.os.Bundle;
import android.support.v4.app.Fragment;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;

import vn.edu.hutech.lvtien.huwatiexpressapplication.R;

/**
 * A simple {@link Fragment} subclass.
 */
public class TripsFragment extends Fragment implements TripsView {


    public TripsFragment() {
        // Required empty public constructor
    }

    public static TripsFragment newInstance() {
        return new TripsFragment();
    }

    @Override
    public View onCreateView(LayoutInflater inflater, ViewGroup container,
                             Bundle savedInstanceState) {
        // Inflate the layout for this fragment
        View view = inflater.inflate(R.layout.fragment_trips, container, false);


        return view;
    }

}
