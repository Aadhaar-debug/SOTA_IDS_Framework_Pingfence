package com.example.chakravyuh;

import android.annotation.SuppressLint;
import android.content.Intent;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.webkit.WebSettings;
import android.webkit.WebView;
import android.widget.ImageView;

public class networkGateway extends AppCompatActivity {

    private WebView webView;
    private ImageView imageView1;

    @SuppressLint({"SetJavaScriptEnabled", "MissingInflatedId"})
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_network_gateway);

        // Find the WebView in the layout
        webView = findViewById(R.id.webView);

        // Enable JavaScript support
        WebSettings webSettings = webView.getSettings();
        webSettings.setJavaScriptEnabled(true);

        imageView1 = findViewById(R.id.imageView4);

        imageView1.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                // Create an Intent to start the new activity
                Intent intent = new Intent(networkGateway.this, dashboard.class);
                startActivity(intent);
                finish();
            }
        });

        // Load the website
        webView.loadUrl("https://aadhaar-debug.github.io/network_analysis_dashboard/");
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