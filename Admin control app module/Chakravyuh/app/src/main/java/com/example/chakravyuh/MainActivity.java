package com.example.chakravyuh;

import android.content.Intent;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.widget.Toast;


import java.util.Timer;
import java.util.TimerTask;

public class MainActivity extends AppCompatActivity {


    Timer timer;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

//        Toast.makeText(getApplicationContext(),"Loading contet",Toast.LENGTH_SHORT).show();
        timer = new Timer();
        timer.schedule(new TimerTask() {
            @Override
            public void run()
            {
                Intent intent1 = new Intent(MainActivity.this, welcome.class);
                startActivity(intent1);
                finish();
            }
        }, 2000);
    }
    @Override
    public void onBackPressed() {
    }


}