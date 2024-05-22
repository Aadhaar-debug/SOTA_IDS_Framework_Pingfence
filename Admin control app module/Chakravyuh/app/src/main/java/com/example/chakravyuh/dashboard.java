package com.example.chakravyuh;

import android.app.Notification;
import android.app.NotificationChannel;
import android.app.NotificationManager;
import android.content.Context;
import android.content.Intent;
import android.graphics.Color;
import android.net.ConnectivityManager;
import android.net.Network;
import android.net.NetworkCapabilities;
import android.net.NetworkInfo;
import android.os.Build;
import android.os.Bundle;
import android.support.v4.app.NotificationCompat;
import android.support.v7.app.AppCompatActivity;
import android.view.View;
import android.widget.ImageView;
import android.widget.TextView;
import android.widget.Toast;


public class dashboard extends AppCompatActivity {

    private static final String CHANNEL_ID = "my_channel";
    private static final int NOTIFICATION_ID = 1;
    private ImageView image;
    private ImageView image1;
    private ImageView image2;
    private ImageView image3;
    private ImageView image15;
    private ImageView image12;
    private TextView TextView1;
    private ImageView noInternetImage;

    public dashboard() {
    }

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_dashboard);

        // Find the ImageView widgets in the layout
        image = findViewById(R.id.imageView8);
        image1 = findViewById(R.id.imageView10);
        image2 = findViewById(R.id.imageView11);
        image3 = findViewById(R.id.imageView14);
        noInternetImage = findViewById(R.id.imageView37);
        TextView1 = findViewById(R.id.textView2);
        image15 = findViewById(R.id.imageView15);
        image12 = findViewById(R.id.imageView12);

        // Hide the no internet image by default
        noInternetImage.setVisibility(View.GONE);

        // Set an OnClickListener for the ImageView
        image.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                // Create an Intent to start the new activity
                Intent intent = new Intent(dashboard.this, aiLivefeed.class);
                startActivity(intent);
                finish();
            }
        });


        // Set an OnClickListener for the ImageView
        image15.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                // Create an Intent to start the new activity
                Intent intent = new Intent(dashboard.this, networkGateway.class);
                startActivity(intent);
                // Show notification
                showNotification();
            }
        });

        // Set an OnClickListener for the ImageView
        image12.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                // Create an Intent to start the new activity
                Intent intent = new Intent(dashboard.this, firewall.class);
                startActivity(intent);
                // Show notification
                showNotification();
            }
        });


        // Set an OnClickListener for the ImageView
        image1.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                // Create an Intent to start the new activity
                Intent intent = new Intent(dashboard.this, dashboard.class);
                startActivity(intent);
                finish();
            }
        });

        // Set an OnClickListener for the ImageView
        image2.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                // Create an Intent to start the new activity
                Intent intent = new Intent(dashboard.this, honeypot.class);
                startActivity(intent);
                finish();
            }
        });

        // Set an OnClickListener for the ImageView
        image3.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                // Create an Intent to start the new activity
                Intent intent = new Intent(dashboard.this, notificationActivity.class);
                startActivity(intent);
                // Show notification
                showNotification();
            }
        });

        // Register network callback to monitor internet connectivity status
        ConnectivityManager connectivityManager =
                (ConnectivityManager) getSystemService(Context.CONNECTIVITY_SERVICE);
        if (connectivityManager != null) {
            if (Build.VERSION.SDK_INT >= Build.VERSION_CODES.N) {
                connectivityManager.registerDefaultNetworkCallback(new ConnectivityManager.NetworkCallback() {
                    @Override
                    public void onAvailable(Network network) {
                        // Internet connectivity is available, hide the no internet image
                        runOnUiThread(new Runnable() {
                            @Override
                            public void run() {
                                noInternetImage.setVisibility(View.GONE);
                                Toast.makeText(dashboard.this, "System Online", Toast.LENGTH_SHORT).show();
                                TextView1.setText("Status : Online");
                            }
                        });
                    }

                    @Override
                    public void onLost(Network network) {
                        // Internet connectivity is lost, show the no internet image
                        runOnUiThread(new Runnable() {
                            @Override
                            public void run() {
                                noInternetImage.setVisibility(View.VISIBLE);
                                Toast.makeText(dashboard.this, "System Offline", Toast.LENGTH_SHORT).show();
                                TextView1.setText("Status : Offline");
                            }
                        });
                    }
                });
            }
        }
    }

    private void showNotification() {
        NotificationManager notificationManager =
                (NotificationManager) getSystemService(Context.NOTIFICATION_SERVICE);

        // Check if Android version is Oreo or higher
        if (Build.VERSION.SDK_INT >= Build.VERSION_CODES.O) {
            // Create NotificationChannel
            NotificationChannel channel = new NotificationChannel(
                    CHANNEL_ID,
                    "My Channel",
                    NotificationManager.IMPORTANCE_HIGH);
            channel.setDescription("My Channel Description");
            channel.enableLights(true);
            channel.setLightColor(Color.RED);
            channel.enableVibration(true);
            notificationManager.createNotificationChannel(channel);
        }

        // Check if device is connected to internet
        if (isConnectedToInternet()) {
            // Remove the image from the ImageView
            image3.setImageDrawable(null);
        } else {
            // Add the image to the ImageView
            image3.setImageResource(R.drawable.imageView37);
        }

        NotificationCompat.Builder builder =
                new NotificationCompat.Builder(this, CHANNEL_ID)
                        .setSmallIcon(R.drawable.beatapplogo)
                        .setContentTitle("Alert !")
                        .setContentText("Intrusion Detected on the Honeypot system");

        notificationManager.notify(NOTIFICATION_ID, builder.build());
    }


    private boolean isConnectedToInternet() {
        ConnectivityManager connectivityManager = (ConnectivityManager) getSystemService(Context.CONNECTIVITY_SERVICE);
        NetworkInfo activeNetworkInfo = connectivityManager.getActiveNetworkInfo();
        return activeNetworkInfo != null && activeNetworkInfo.isConnected();
    }
}