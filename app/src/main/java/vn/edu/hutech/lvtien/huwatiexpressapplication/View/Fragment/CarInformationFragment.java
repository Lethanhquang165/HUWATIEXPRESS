package vn.edu.hutech.lvtien.huwatiexpressapplication.View.Fragment;


import android.os.Bundle;
import android.support.v4.app.Fragment;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;

import vn.edu.hutech.lvtien.huwatiexpressapplication.R;

/**
 * A simple {@link Fragment} subclass.
 */
public class CarInformationFragment extends Fragment {


    public CarInformationFragment() {
        // Required empty public constructor
    }


    @Override
    public View onCreateView(LayoutInflater inflater, ViewGroup container,
                             Bundle savedInstanceState) {
        // Inflate the layout for this fragment
        return inflater.inflate(R.layout.fragment_car_information, container, false);
    }

}
