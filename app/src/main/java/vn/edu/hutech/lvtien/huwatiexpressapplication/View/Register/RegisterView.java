package vn.edu.hutech.lvtien.huwatiexpressapplication.View.Register;

/**
 * Created by lvant on 14/06/2017.
 */

public interface RegisterView {
    void RegisterSuccess(String fullname, String username, String password);
    void RegisterFail(String fullname, String username, String password);
    void Login();
}
