package vn.edu.hutech.lvtien.huwatiexpressapplication.Presenter.Login;

import vn.edu.hutech.lvtien.huwatiexpressapplication.View.Login.LoginView;

/**
 * Created by lvant on 14/06/2017.
 */

public class LoginPresenter implements LoginPresenterImp {

    LoginView _loginView;

    public LoginPresenter(LoginView _loginView) {
        this._loginView = _loginView;
    }

    @Override
    public void Login(String username, String password) {
        _loginView.ShowProgressBar(true);
        if(username.equals("admin") && password.equals("123")){
            _loginView.LoginSuccess(username);
            _loginView.ShowProgressBar(false);
        }
        else {
            _loginView.ShowProgressBar(false);
            _loginView.LoginFail(password);
        }
    }

    @Override
        public void Register() {
        _loginView.ClickedRegister();
    }
}
