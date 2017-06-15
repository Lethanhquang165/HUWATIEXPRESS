package vn.edu.hutech.lvtien.huwatiexpressapplication.Presenter.Register;

import vn.edu.hutech.lvtien.huwatiexpressapplication.View.Register.RegisterView;

/**
 * Created by lvant on 14/06/2017.
 */

public class RegisterPresenter implements RegisterPresenterImp {

    private RegisterView _view;

    public RegisterPresenter(RegisterView view) {
        this._view = view;
    }

    @Override
    public void Login() {
        _view.Login();
    }

    @Override
    public void Register(String fullname, String username, String password) {
        _view.RegisterSuccess(fullname, username, password);
    }
}
