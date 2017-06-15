package vn.edu.hutech.lvtien.huwatiexpressapplication.View.Register;


import android.content.Intent;
import android.os.Bundle;
import android.support.design.widget.TextInputEditText;
import android.support.v4.app.Fragment;
import android.util.Log;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.Button;
import android.widget.Toast;

import butterknife.BindView;
import butterknife.ButterKnife;
import butterknife.OnClick;
import butterknife.Unbinder;
import vn.edu.hutech.lvtien.huwatiexpressapplication.Presenter.Register.RegisterPresenter;
import vn.edu.hutech.lvtien.huwatiexpressapplication.R;
import vn.edu.hutech.lvtien.huwatiexpressapplication.View.Login.LoginActivity;
import vn.edu.hutech.lvtien.huwatiexpressapplication.View.MainActivity;

/**
 * A simple {@link Fragment} subclass.
 */
public class RegisterFragment extends Fragment implements RegisterView {

    private static final String TAG_REGISTER = "REGISTER_ACTIVITY: ";
    @BindView(R.id.edtFullName)
    TextInputEditText edtFullName;
    @BindView(R.id.edtUsername)
    TextInputEditText edtUsername;
    @BindView(R.id.edtPassword)
    TextInputEditText edtPassword;
    @BindView(R.id.btnRegister)
    Button btnRegister;
    @BindView(R.id.btnLogin)
    Button btnLogin;
    Unbinder unbinder;

    private RegisterPresenter _presenter;

    public RegisterFragment() {
        // Required empty public constructor
    }

    public static RegisterFragment newInstance() {
        return new RegisterFragment();
    }

    @Override
    public View onCreateView(LayoutInflater inflater, ViewGroup container,
                             Bundle savedInstanceState) {
        // Inflate the layout for this fragment
        View view = inflater.inflate(R.layout.fragment_register, container, false);

        _presenter = new RegisterPresenter(this);
        unbinder = ButterKnife.bind(this, view);
        return view;
    }

    @Override
    public void RegisterSuccess(String fullname, String user, String password) {
        Log.d(TAG_REGISTER, "Successed With" + fullname + " " + user + " " + password);
        startActivity(new Intent(getContext(), MainActivity.class));
        getActivity().finish();
    }

    @Override
    public void RegisterFail(String fullname, String user, String password) {
        Log.d(TAG_REGISTER, "Failed With" + fullname + " " + user + " " + password);
        Toast.makeText(getContext(), "Register Failed", Toast.LENGTH_LONG).show();
    }

    @Override
    public void Login() {
        startActivity(new Intent(getContext(), LoginActivity.class));
        getActivity().finish();
    }

    @Override
    public void onDestroyView() {
        super.onDestroyView();
        unbinder.unbind();
    }

    @OnClick({R.id.btnRegister, R.id.btnLogin})
    public void onViewClicked(View view) {
        switch (view.getId()) {
            case R.id.btnRegister:
                String fullname = edtFullName.getText().toString();
                String username = edtUsername.getText().toString();
                String password = edtPassword.getText().toString();
                _presenter.Register(fullname, username, password);
                break;
            case R.id.btnLogin:
                _presenter.Login();
                break;
        }
    }
}
