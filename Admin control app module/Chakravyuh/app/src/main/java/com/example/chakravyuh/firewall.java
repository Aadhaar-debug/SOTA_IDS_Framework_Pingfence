package com.example.chakravyuh;

import android.annotation.SuppressLint;
import android.content.Intent;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.webkit.WebSettings;
import android.webkit.WebView;
import android.widget.ImageView;

public class firewall extends AppCompatActivity {

    private WebView webView;
    private ImageView imageview;

    @SuppressLint({"SetJavaScriptEnabled", "MissingInflatedId"})
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_firewall);

        imageview = findViewById(R.id.imageView4);

        imageview.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                // Create an Intent to start the new activity
                Intent intent = new Intent(firewall.this, dashboard.class);
                startActivity(intent);
                finish();
            }
        });

        // Enable JavaScript support
        WebSettings webSettings = webView.getSettings();
        webSettings.setJavaScriptEnabled(true);

        // Load the website
        webView.loadUrl("192.168.29.1");
    }

    @Override
    public void onBackPressed() {
        // If the WebView can go back, go back to the previous page
        if (webView.canGoBack()) {
            webView.goBack();
        } else {
            super.onBackPressed();
        }
    }
}