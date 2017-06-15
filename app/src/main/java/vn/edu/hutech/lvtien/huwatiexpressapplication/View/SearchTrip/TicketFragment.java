package vn.edu.hutech.lvtien.huwatiexpressapplication.View.SearchTrip;

import android.content.Intent;
import android.os.AsyncTask;
import android.os.Bundle;
import android.support.v4.app.Fragment;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.ImageView;
import android.widget.Toast;

import java.io.IOException;
import java.util.concurrent.TimeUnit;

import butterknife.BindView;
import butterknife.ButterKnife;
import butterknife.OnClick;
import butterknife.Unbinder;
import okhttp3.OkHttpClient;
import okhttp3.Request;
import okhttp3.Response;
import vn.edu.hutech.lvtien.huwatiexpressapplication.Presenter.SearchTrip.TicketPresenter;
import vn.edu.hutech.lvtien.huwatiexpressapplication.R;
import vn.edu.hutech.lvtien.huwatiexpressapplication.View.ListTrips.TripsActivity;

public class TicketFragment extends Fragment implements TicketView{

    @BindView(R.id.btnNext)
    ImageView btnNext;
    Unbinder unbinder;

    private TicketPresenter _presenter;

    public TicketFragment() {
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
        View view = inflater.inflate(R.layout.fragment_ticket, container, false);

        _presenter = new TicketPresenter(this);

        unbinder = ButterKnife.bind(this, view);
        return view;

    }

    @Override
    public void onDestroyView() {
        super.onDestroyView();
        unbinder.unbind();
    }

    @OnClick(R.id.btnNext)
    public void onViewClicked() {
        _presenter.SearchTrip();
    }

    @Override
    public void ClickedNext() {
        Intent intent = new Intent(getContext(), TripsActivity.class);
        startActivity(intent);
    }

    @Override
    public void GetDataFromServer() {
        new GetUrl().execute("http://www.json-generator.com/api/json/get/cfsjFSxBki?indent=2");
    }

    private class GetUrl extends AsyncTask<String, String, String>{
        OkHttpClient client = new OkHttpClient.Builder()
                .connectTimeout(10, TimeUnit.SECONDS)
                .writeTimeout(10, TimeUnit.SECONDS)
                .readTimeout(15, TimeUnit.SECONDS)
                .retryOnConnectionFailure(true)
                .build();

        @Override
        protected String doInBackground(String... params) {
            Request.Builder builder = new Request.Builder();
            builder.url(params[0]);

            Request request = builder.build();

            try {
                Response response = client.newCall(request).execute();
                return response.body().string();
            } catch (IOException e) {
                e.printStackTrace();
            }
            return null;
        }

        @Override
        protected void onPostExecute(String s) {
            if(!s.isEmpty()){
                Toast.makeText(getContext(), s, Toast.LENGTH_LONG).show();
            }
            else {
                Toast.makeText(getContext(), "Lỗi", Toast.LENGTH_SHORT).show();
            }
            super.onPostExecute(s);
        }
    }
}
