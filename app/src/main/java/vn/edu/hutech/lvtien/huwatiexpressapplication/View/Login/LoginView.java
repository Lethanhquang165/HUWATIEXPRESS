package vn.edu.hutech.lvtien.huwatiexpressapplication.View.Login;

/**
 * Created by lvant on 14/06/2017.
 */

public interface LoginView {
    void LoginFail(String user);
    void LoginSuccess(String user);
    void ClickedRegister();
    void OpenHomeActivity();
    void ShowProgressBar(boolean isShow);
}
