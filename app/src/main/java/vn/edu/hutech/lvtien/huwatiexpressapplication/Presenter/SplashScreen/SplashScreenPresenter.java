package vn.edu.hutech.lvtien.huwatiexpressapplication.Presenter.SplashScreen;

import android.content.Intent;

import vn.edu.hutech.lvtien.huwatiexpressapplication.View.Login.LoginActivity;
import vn.edu.hutech.lvtien.huwatiexpressapplication.View.SplashScreen.SplashScreenView;

/**
 * Created by lvant on 13/06/2017.
 */

public class SplashScreenPresenter implements SplashScreenPresenterImp{

    SplashScreenView _splashScreenView;

    public SplashScreenPresenter(SplashScreenView splashScreenView) {
        this._splashScreenView = splashScreenView;
    }

    @Override
    public void LoadSplashScreen() {
        Thread myThread = new Thread(){
            @Override
            public void run() {
                try {
                    sleep(1000);
                    _splashScreenView.ShowActivityLogin();
                } catch (InterruptedException e) {
                    e.printStackTrace();
                }
            }
        };
        myThread.start();
    }
}
