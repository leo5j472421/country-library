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
            <td>{{ country.languages }}</td>
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
export default {
  name: "App",
  data() {
    return {
      countries: [
        {
          id: 1,
          name: "中華民國",
          languages: "中文",
          capital: "臺北市",
          currency: "新台幣",
          population: 23000000,
        },
        {
          id: 2,
          name: "日本",
          languages: "日語",
          capital: "東京",
          currency: "日圓",
          population: 125000000,
        },
        {
          id: 3,
          name: "美國",
          languages: "英語",
          capital: "華盛頓特區",
          currency: "美元",
          population: 330000000,
        },
      ],
    };
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