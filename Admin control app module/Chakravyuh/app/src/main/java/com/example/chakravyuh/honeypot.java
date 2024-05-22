package com.example.chakravyuh;

import android.content.Intent;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.ImageView;

public class honeypot extends AppCompatActivity {

    private ImageView imageview;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_honeypot);

        imageview = findViewById(R.id.imageView5);

        imageview.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                // Create an Intent to start the new activity
                Intent intent = new Intent(honeypot.this, dashboard.class);
                startActivity(intent);
                finish();
            }
        });

    }
}