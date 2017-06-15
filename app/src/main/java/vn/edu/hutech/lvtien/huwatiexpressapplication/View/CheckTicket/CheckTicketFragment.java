package vn.edu.hutech.lvtien.huwatiexpressapplication.View.CheckTicket;

import android.content.Intent;
import android.os.Bundle;
import android.support.v4.app.Fragment;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.Button;
import android.widget.EditText;

import butterknife.BindView;
import butterknife.ButterKnife;
import butterknife.OnClick;
import butterknife.Unbinder;
import vn.edu.hutech.lvtien.huwatiexpressapplication.Presenter.CheckTicket.CheckTicketPresenter;
import vn.edu.hutech.lvtien.huwatiexpressapplication.R;
import vn.edu.hutech.lvtien.huwatiexpressapplication.View.Activity.CheckTicketsListActivity;

public class CheckTicketFragment extends Fragment implements CheckTicketView {

    @BindView(R.id.edtCodeTicket)
    EditText edtCodeTicket;
    @BindView(R.id.edtEmailOrPhone)
    EditText edtEmailOrPhone;
    @BindView(R.id.btnSearch)
    Button btnSearch;
    Unbinder unbinder;

    private CheckTicketPresenter _presenter;

    public CheckTicketFragment() {
        // Required empty public constructor
    }

    @Override
    public void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
    }

    @Override
    public View onCreateView(LayoutInflater inflater, ViewGroup container,
                             Bundle savedInstanceState) {
        // Inflate the layout for this fragment
        View view = inflater.inflate(R.layout.fragment_check_ticket, container, false);
        unbinder = ButterKnife.bind(this, view);

        _presenter = new CheckTicketPresenter(this);

        return view;
    }


    @Override
    public void onDetach() {
        super.onDetach();
    }


    @Override
    public void onDestroyView() {
        super.onDestroyView();
        unbinder.unbind();
    }

    @OnClick(R.id.btnSearch)
    public void onViewClicked() {
        _presenter.SearchTicket();
    }

    @Override
    public void ShowCheckTicketsList() {
        Intent intent = new Intent(getContext(), CheckTicketsListActivity.class);
        startActivity(intent);
    }
}
