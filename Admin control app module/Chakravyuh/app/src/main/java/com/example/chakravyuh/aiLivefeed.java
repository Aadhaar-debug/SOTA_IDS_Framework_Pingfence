package com.example.chakravyuh;

import android.annotation.SuppressLint;
import android.content.Intent;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.webkit.WebSettings;
import android.webkit.WebView;
import android.widget.ImageView;

public class aiLivefeed extends AppCompatActivity {

    private WebView webView;

    private ImageView imageview1;

    @SuppressLint({"SetJavaScriptEnabled", "MissingInflatedId"})
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_ai_livefeed);

        // Find the WebView in the layout
        webView = findViewById(R.id.webView);
        imageview1 = findViewById(R.id.imageView4);



        // Enable JavaScript support
        WebSettings webSettings = webView.getSettings();
        webSettings.setJavaScriptEnabled(true);


        imageview1.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                // Create an Intent to start the new activity
                Intent intent = new Intent(aiLivefeed.this, dashboard.class);
                startActivity(intent);
                finish();
            }
        });


        // Load the website
        webView.loadUrl("https://www.google.com");
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