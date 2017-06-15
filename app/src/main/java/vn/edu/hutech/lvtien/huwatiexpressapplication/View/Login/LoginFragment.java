package vn.edu.hutech.lvtien.huwatiexpressapplication.View.Login;


import android.content.Intent;
import android.os.Bundle;
import android.support.design.widget.TextInputEditText;
import android.support.v4.app.Fragment;
import android.util.Log;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.Button;
import android.widget.CheckBox;
import android.widget.ImageView;
import android.widget.ProgressBar;
import android.widget.Toast;

import butterknife.BindView;
import butterknife.ButterKnife;
import butterknife.OnClick;
import butterknife.Unbinder;
import vn.edu.hutech.lvtien.huwatiexpressapplication.Presenter.Login.LoginPresenter;
import vn.edu.hutech.lvtien.huwatiexpressapplication.R;
import vn.edu.hutech.lvtien.huwatiexpressapplication.View.MainActivity;
import vn.edu.hutech.lvtien.huwatiexpressapplication.View.Register.RegisterActivity;

/**
 * A simple {@link Fragment} subclass.
 */
public class LoginFragment extends Fragment implements LoginView {

    LoginPresenter _presenter;
    @BindView(R.id.btnLoginWithFacebook)
    ImageView btnLoginWithFacebook;
    @BindView(R.id.btnLoginWithGoogle)
    ImageView btnLoginWithGoogle;
    @BindView(R.id.edtUsername)
    TextInputEditText edtUsername;
    @BindView(R.id.edtPassword)
    TextInputEditText edtPassword;
    @BindView(R.id.cbRemember)
    CheckBox cbRemember;
    @BindView(R.id.btnLogin)
    Button btnLogin;
    @BindView(R.id.btnRegister)
    Button btnRegister;
    @BindView(R.id.progressBar)
    ProgressBar progressBar;
    Unbinder unbinder;

     private static final String TAG_LOGIN  = "LOGIN_ACTIVITY: ";

    public LoginFragment() {
        // Required empty public constructor
    }

    public static LoginFragment newInstance() {
        return new LoginFragment();
    }

    @Override
    public View onCreateView(LayoutInflater inflater, ViewGroup container,
                             Bundle savedInstanceState) {
        // Inflate the layout for this fragment
        View view = inflater.inflate(R.layout.fragment_login, container, false);

        _presenter = new LoginPresenter(this);
        OpenHomeActivity();
        unbinder = ButterKnife.bind(this, view);
        return view;
    }

    @Override
    public void LoginFail(String user) {
        Log.d(TAG_LOGIN, "Login Failed" + user);
        Toast.makeText(this.getContext(), "Login Failed", Toast.LENGTH_LONG).show();
    }

    @Override
    public void LoginSuccess(String user) {
        Log.d(TAG_LOGIN, "Login Success With " + user);
        OpenHomeActivity();
    }

    @Override
    public void ClickedRegister() {
        Intent intent = new Intent(this.getContext(), RegisterActivity.class);
        this.startActivity(intent);
    }

    @Override
    public void OpenHomeActivity() {
        Intent intent = new Intent(this.getContext(), MainActivity.class);
        this.startActivity(intent);
        this.getActivity().finish();
    }

    @Override
    public void ShowProgressBar(boolean isShow) {
        progressBar.setVisibility(isShow ? View.VISIBLE : View.GONE);
    }

    @Override
    public void onDestroyView() {
        super.onDestroyView();
        unbinder.unbind();
    }

    @OnClick({R.id.btnLoginWithFacebook, R.id.btnLoginWithGoogle, R.id.btnLogin, R.id.btnRegister})
    public void onViewClicked(View view) {
        switch (view.getId()) {
            case R.id.btnLoginWithFacebook:
                break;
            case R.id.btnLoginWithGoogle:
                break;
            case R.id.btnLogin:
                _presenter.Login(edtUsername.getText().toString(), edtPassword.getText().toString());
                break;
            case R.id.btnRegister:
                _presenter.Register();
                break;
        }
    }
}
