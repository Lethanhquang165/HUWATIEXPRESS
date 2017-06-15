package vn.edu.hutech.lvtien.huwatiexpressapplication.View.Register;

import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;

import vn.edu.hutech.lvtien.huwatiexpressapplication.R;
import vn.edu.hutech.lvtien.huwatiexpressapplication.View.Util.ActivityUtils;

public class RegisterActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_register);

        RegisterFragment loginFragment = (RegisterFragment)
                getSupportFragmentManager().findFragmentById(R.id.contentFrame);
        if(loginFragment == null){
            loginFragment = RegisterFragment.newInstance();
            ActivityUtils.addFragmentToActivity(
                    getSupportFragmentManager(),
                    loginFragment,
                    R.id.contentFrame
            );
        }
    }
}
