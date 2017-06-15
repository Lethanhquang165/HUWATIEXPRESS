package vn.edu.hutech.lvtien.huwatiexpressapplication.Presenter.CheckTicket;

import vn.edu.hutech.lvtien.huwatiexpressapplication.View.CheckTicket.CheckTicketView;

/**
 * Created by lvant on 15/06/2017.
 */

public class CheckTicketPresenter implements CheckTicketPresenterImp {
    CheckTicketView _view;

    public CheckTicketPresenter(CheckTicketView _view) {
        this._view = _view;
    }

    @Override
    public void SearchTicket() {
        _view.ShowCheckTicketsList();
    }
}
