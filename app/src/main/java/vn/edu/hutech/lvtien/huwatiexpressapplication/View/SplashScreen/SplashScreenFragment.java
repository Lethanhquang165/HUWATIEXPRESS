package vn.edu.hutech.lvtien.huwatiexpressapplication.View.SplashScreen;


import android.content.Intent;
import android.os.Bundle;
import android.support.v4.app.Fragment;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;

import vn.edu.hutech.lvtien.huwatiexpressapplication.Presenter.SplashScreen.SplashScreenPresenter;
import vn.edu.hutech.lvtien.huwatiexpressapplication.Presenter.SplashScreen.SplashScreenPresenterImp;
import vn.edu.hutech.lvtien.huwatiexpressapplication.R;
import vn.edu.hutech.lvtien.huwatiexpressapplication.View.Login.LoginActivity;

/**
 * A simple {@link Fragment} subclass.
 */
public class SplashScreenFragment extends Fragment implements SplashScreenView {

    private SplashScreenPresenterImp _presenter;

    public SplashScreenFragment() {
        // Required empty public constructor
    }

    public static SplashScreenFragment newInstance() {
        return new SplashScreenFragment();
    }

    @Override
    public View onCreateView(LayoutInflater inflater, ViewGroup container,
                             Bundle savedInstanceState) {
        // Inflate the layout for this fragment
        View view = inflater.inflate(R.layout.fragment_splash_screen, container, false);

        _presenter = new SplashScreenPresenter(this);

        _presenter.LoadSplashScreen();
        return view;
    }

    @Override
    public void ShowActivityLogin() {
        Intent intent = new Intent(this.getContext(), LoginActivity.class);
        startActivity(intent);
        this.getActivity().finish();
    }
}
