package vn.edu.hutech.lvtien.huwatiexpressapplication.View.Fragment;

import android.os.Bundle;
import android.support.v4.app.Fragment;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;

import vn.edu.hutech.lvtien.huwatiexpressapplication.R;

public class CheckTicketFragment extends Fragment {

    public CheckTicketFragment() {
        // Required empty public constructor
    }


    @Override
    public void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
    }

    @Override
    public View onCreateView(LayoutInflater inflater, ViewGroup container,
                             Bundle savedInstanceState) {
        // Inflate the layout for this fragment
        return inflater.inflate(R.layout.fragment_check_ticket, container, false);
    }


    @Override
    public void onDetach() {
        super.onDetach();
    }


}
