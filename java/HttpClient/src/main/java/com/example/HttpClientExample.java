package com.example;

import org.apache.http.client.HttpClient;
import org.apache.http.client.methods.HttpGet;
import org.apache.http.impl.client.HttpClients;
import org.apache.http.util.EntityUtils;
import org.apache.http.HttpResponse;

public class HttpClientExample {
    public static void main(String[] args) {
        // Create an HttpClient instance
        HttpClient httpClient = HttpClients.createDefault();
        
        // Create an HttpGet request with the URL
        HttpGet httpGet = new HttpGet("https://abc.com");
        
        try {
            // Execute the request
            HttpResponse response = httpClient.execute(httpGet);
            
            // Get the response status code
            int statusCode = response.getStatusLine().getStatusCode();
            System.out.println("Response Status Code: " + statusCode);
            
            // Get the response body
            String responseBody = EntityUtils.toString(response.getEntity());
            System.out.println("Response Body: " + responseBody);
        } catch (Exception e) {
            e.printStackTrace();
        }
    }
}
