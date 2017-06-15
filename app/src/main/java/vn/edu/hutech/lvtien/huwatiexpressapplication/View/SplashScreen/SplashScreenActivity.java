package vn.edu.hutech.lvtien.huwatiexpressapplication.View.SplashScreen;

import android.content.Intent;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;

import vn.edu.hutech.lvtien.huwatiexpressapplication.R;
import vn.edu.hutech.lvtien.huwatiexpressapplication.View.Login.LoginActivity;
import vn.edu.hutech.lvtien.huwatiexpressapplication.View.Util.ActivityUtils;

public class SplashScreenActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_splash_screen);

        SplashScreenFragment splashScreenFragment =
                (SplashScreenFragment) getSupportFragmentManager().findFragmentById(R.id.contentFrame);
        if(splashScreenFragment == null){
            splashScreenFragment = SplashScreenFragment.newInstance();
            ActivityUtils.addFragmentToActivity(
                    getSupportFragmentManager(),
                    splashScreenFragment,
                    R.id.contentFrame);
        }
    }
}
