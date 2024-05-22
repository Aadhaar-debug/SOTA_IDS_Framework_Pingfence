package com.example.chakravyuh;

import android.content.Intent;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;

import java.util.Timer;
import java.util.TimerTask;

public class welcome extends AppCompatActivity {


    Timer timer;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_welcome);

//        Toast.makeText(getApplicationContext(),"Loading contet",Toast.LENGTH_SHORT).show();
        timer = new Timer();
        timer.schedule(new TimerTask() {
            @Override
            public void run()
            {
                Intent intent1 = new Intent(welcome.this, login.class);
                startActivity(intent1);
                finish();
            }
        }, 2000);
    }
    @Override
    public void onBackPressed() {
    }


}