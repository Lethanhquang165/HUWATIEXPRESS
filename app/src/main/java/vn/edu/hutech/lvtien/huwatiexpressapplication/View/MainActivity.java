package vn.edu.hutech.lvtien.huwatiexpressapplication.View;

import android.content.res.Configuration;
import android.os.Bundle;
import android.support.annotation.NonNull;
import android.support.annotation.Nullable;
import android.support.design.widget.AppBarLayout;
import android.support.design.widget.NavigationView;
import android.support.v4.app.Fragment;
import android.support.v4.app.FragmentTransaction;
import android.support.v4.view.GravityCompat;
import android.support.v4.widget.DrawerLayout;
import android.support.v7.app.ActionBarDrawerToggle;
import android.support.v7.app.AppCompatActivity;
import android.support.v7.widget.Toolbar;
import android.view.MenuItem;

import java.util.HashMap;

import butterknife.BindView;
import butterknife.ButterKnife;
import vn.edu.hutech.lvtien.huwatiexpressapplication.R;
import vn.edu.hutech.lvtien.huwatiexpressapplication.View.Fragment.AboutUsFragment;
import vn.edu.hutech.lvtien.huwatiexpressapplication.View.Fragment.CarInformationFragment;
import vn.edu.hutech.lvtien.huwatiexpressapplication.View.Fragment.ChangePasswordFragment;
import vn.edu.hutech.lvtien.huwatiexpressapplication.View.CheckTicket.CheckTicketFragment;
import vn.edu.hutech.lvtien.huwatiexpressapplication.View.Fragment.ContactUsFragment;
import vn.edu.hutech.lvtien.huwatiexpressapplication.View.Fragment.MyAccountFragment;
import vn.edu.hutech.lvtien.huwatiexpressapplication.View.Fragment.PassengerInformationFragment;
import vn.edu.hutech.lvtien.huwatiexpressapplication.View.Fragment.ScheduleFragment;
import vn.edu.hutech.lvtien.huwatiexpressapplication.View.SearchTrip.TicketFragment;

public class MainActivity extends AppCompatActivity implements NavigationView.OnNavigationItemSelectedListener {

    @BindView(R.id.toolbar)
    Toolbar toolbar;
    @BindView(R.id.appBarLayout)
    AppBarLayout appBarLayout;
    @BindView(R.id.nav_view)
    NavigationView navView;
    @BindView(R.id.drawer_layout)
    DrawerLayout drawerLayout;

    HashMap<String, String> _title;

    private ActionBarDrawerToggle drawerToggle;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        ButterKnife.bind(this);

        _title = new HashMap<>();
        _title.put("TITLE_TICKET", getString(R.string.menu_ticket));
        _title.put("TITLE_CHECK_TICKET", getString(R.string.menu_check_ticket));
        _title.put("TITLE_SCHEDULE", getString(R.string.menu_schedule));
        _title.put("TITLE_CAR_INFORMATION", getString(R.string.menu_car_information));
        _title.put("TITLE_PASSENGER_INFORMATION", getString(R.string.menu_passenger_information));
        _title.put("TITLE_MY_ACCOUNT", getString(R.string.menu_my_account));
        _title.put("TITLE_CHANGE_PASSWORD", getString(R.string.menu_change_password));
        _title.put("TITLE_CONTACT_US", getString(R.string.menu_contact_us));
        _title.put("TITLE_ABOUT_US", getString(R.string.menu_about_us));

        setSupportActionBar(toolbar);

        drawerToggle = new ActionBarDrawerToggle(
                this, drawerLayout, toolbar, R.string.navigation_drawer_open, R.string.navigation_drawer_open);

        /** Set the drawer toggle as the DrawerListener */
        drawerLayout.setDrawerListener(drawerToggle);

        navView.setNavigationItemSelectedListener(this);

    }

    @Override
    protected void onPostCreate(@Nullable Bundle savedInstanceState) {
        super.onPostCreate(savedInstanceState);
        // Sync the toggle state after onRestoreInstanceState has occurred.
        drawerToggle.syncState();

        // Add fragment Ticket when activity home start
        //navView.getMenu().getItem(0).setChecked(true);
        selectedItem(R.id.nav_ticket);
    }

    @Override
    public void onConfigurationChanged(Configuration newConfig) {
        super.onConfigurationChanged(newConfig);
        drawerToggle.onConfigurationChanged(newConfig);
    }

    @Override
    public boolean onNavigationItemSelected(@NonNull MenuItem item) {
        // Handle navigation view item clicks here.
        int id = item.getItemId();
        selectedItem(id);

        return true;
    }

    @Override
    public void onBackPressed() {
        if (drawerLayout.isDrawerOpen(GravityCompat.START)) {
            drawerLayout.closeDrawer(GravityCompat.START);
        } else {
            super.onBackPressed();
        }
    }

    private void selectedItem(int id){
        Fragment newFragment = null;
        FragmentTransaction transaction = getSupportFragmentManager().beginTransaction();
        switch (id) {
            case R.id.nav_ticket:
                newFragment = new TicketFragment();
                setTitle(_title.get("TITLE_TICKET"));
                break;
            case R.id.nav_check_ticket:
                newFragment = new CheckTicketFragment();
                setTitle(_title.get("TITLE_CHECK_TICKET"));
                break;
            case R.id.nav_schedule:
                newFragment = new ScheduleFragment();
                setTitle(_title.get("TITLE_SCHEDULE"));
                break;
            case R.id.nav_car_information:
                newFragment = new CarInformationFragment();
                setTitle(_title.get("TITLE_CAR_INFORMATION"));
                break;
            case R.id.nav_passenger_information:
                newFragment = new PassengerInformationFragment();
                setTitle(_title.get("TITLE_PASSENGER_INFORMATION"));
                break;
            case R.id.nav_account_information:
                newFragment = new MyAccountFragment();
                setTitle(_title.get("TITLE_MY_ACCOUNT"));
                break;
            case R.id.nav_change_password:
                newFragment = new ChangePasswordFragment();
                setTitle(_title.get("TITLE_CHANGE_PASSWORD"));
                break;
            case R.id.nav_logout:
                return;
            case R.id.nav_share:
                return;
            case R.id.nav_contact_us:
                newFragment = new ContactUsFragment();
                setTitle(_title.get("TITLE_CONTACT_US"));
                break;
            case R.id.nav_about_us:
                newFragment = new AboutUsFragment();
                setTitle(_title.get("TITLE_ABOUT_US"));
                break;
        }
        transaction.replace(R.id.fragmentContainer, newFragment);
        //transaction.addToBackStack(null);
        transaction.commit();

        DrawerLayout drawer = (DrawerLayout) findViewById(R.id.drawer_layout);
        drawer.closeDrawer(GravityCompat.START);
    }
}


