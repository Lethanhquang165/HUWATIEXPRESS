package vn.edu.hutech.lvtien.huwatiexpressapplication.Presenter.SearchTrip;

import vn.edu.hutech.lvtien.huwatiexpressapplication.View.SearchTrip.TicketView;

/**
 * Created by lvant on 15/06/2017.
 */

public class TicketPresenter implements TicketPresenterImp {
    private TicketView _view;

    public TicketPresenter(TicketView _view) {
        this._view = _view;
    }

    @Override
    public void SearchTrip() {
        _view.GetDataFromServer();
        _view.ClickedNext();
    }
}
