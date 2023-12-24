<template>
  <div class="container">
    <header>
      <h1>國家列表</h1>
    </header>
    <main>
      <table>
        <thead>
          <tr>
            <th>ID</th>
            <th>國家名稱</th>
            <th>語言</th>
            <th>首都</th>
            <th>貨幣</th>
            <th>人口</th>
          </tr>
        </thead>
        <tbody>
          <tr v-for="country in countries" :key="country.id">
            <td>{{ country.id }}</td>
            <td>{{ country.name }}</td>
            <td>{{ country.language }}</td>
            <td>{{ country.capital }}</td>
            <td>{{ country.currency }}</td>
            <td>{{ country.population }}</td>
          </tr>
        </tbody>
      </table>
    </main>
  </div>
</template>

<script>
import axios from 'axios';

export default {
  name: 'App',
  data() {
    return {
      countries: [],
      loading: false,
    };
  },
  mounted() {
    this.fetchCountries();
  },
  methods: {
    async fetchCountries() {
      this.loading = true;
      try {
        const response = await axios.get('https://localhost:7252/Country');
        this.countries = response.data;
      } catch (error) {
        console.error('Error fetching countries:', error);
      } finally {
        this.loading = false;
      }
    },
  },
};
</script>

<style>
.container {
  width: 800px;
  margin: 0 auto;
}

header {
  background-color: #ffffff;
  padding: 20px;
}

h1 {
  font-size: 24px;
}

table {
  width: 100%;
  border-collapse: collapse;
}

th,
td {
  border: 1px solid #ccc;
  padding: 10px;
}
</style>